
using Microsoft.AspNetCore.Mvc;
using Shopping.Data;
using Shopping.Models;
using Shopping.Models.Dto;
using System.Net;


namespace Shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly ShoppingDbContext _db;
        private ApiResponse _response;
        //private readonly IBlobService _blobService;
        //private readonly IMapper _mapper;
        public MenuItemController(ShoppingDbContext db/*, IMapper mapper*//* IBlobService blobService*/)
        {
            //_blobService = blobService;
            _db = db;
            //_mapper = mapper;
            _response = new ApiResponse();
        }

        [HttpGet]
        public IActionResult GetMenuItems()
        {
            _response.Result = _db.MenuItems;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }

        [HttpGet("{id:int}", Name = "GetMenuItem")]
        public IActionResult GetMenuItem(int id)
        {
            if (id == 0)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                return BadRequest(_response);
            }
            MenuItem menuItem = _db.MenuItems.FirstOrDefault(x => x.Id == id);
            if (menuItem == null)
            {
                _response.StatusCode = HttpStatusCode.NotFound;
                _response.IsSuccess = false;
                return NotFound(_response);
            }
            _response.Result = menuItem;
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> CreateMenuItem([FromForm]MenuItemCreateDTO menuItemCreateDTO)//using from form instead of from party because we need to upload an image when using menu items
        {
            try
            {
                if(ModelState.IsValid)
                {
                    //if (menuItemCreateDTO.File == null || menuItemCreateDTO.File.Length == 0)
                    //{
                    //    _response.StatusCode = HttpStatusCode.BadRequest;
                    //    _response.IsSuccess = false;
                    //    return BadRequest("File Empty or not selected");
                    //}
                    //using (var memoryStream = new MemoryStream())
                    //{
                    //    await menuItemCreateDTO.File.CopyToAsync(memoryStream);
                    //    var menuItemToCreate = new MenuItem
                    //    {
                    //        Name = menuItemCreateDTO.Name,
                    //        Description = menuItemCreateDTO.Description,
                    //        SpecialTag = menuItemCreateDTO.SpecialTag,
                    //        Category = menuItemCreateDTO.Category,
                    //        Price = menuItemCreateDTO.Price,
                    //        Image = memoryStream.ToArray()
                    //    };
                    //    _db.MenuItems.Add(menuItemToCreate);
                    //    _db.SaveChanges();
                    //    _response.Result = menuItemToCreate;
                    //    _response.StatusCode = HttpStatusCode.Created;
                    //    return CreatedAtRoute("GetMenuItem", new { id = menuItemToCreate.Id }, _response);

                    //}
                    //creating a new file name for my files i am uplaoding 
                    //string fileName = $"{Guid.NewGuid()}{Path.GetExtension(menuItemCreateDTO.File.FileName)}";
                    //converting menuitem dto to menu items,so as to put the data in menu items
                    MenuItem menuItemToCreate = new()
                    {
                        Name = menuItemCreateDTO.Name,
                        Price = menuItemCreateDTO.Price,
                        Category = menuItemCreateDTO.Category,
                        SpecialTag = menuItemCreateDTO.SpecialTag,
                        Description = menuItemCreateDTO.Description,
                        Image= menuItemCreateDTO.Image,
                        //Image = await _blobService.UploadBlob(fileName, SD.SD_Storage_Container, menuItemCreateDTO.File),
                    };
                    _db.MenuItems.Add(menuItemToCreate);
                    _db.SaveChanges();
                    _response.Result = menuItemToCreate;
                    _response.StatusCode = HttpStatusCode.Created;
                    return CreatedAtRoute("GetMenuItem", new { id = menuItemToCreate.Id }, _response);

                    //MenuItem menuItemToCreate = _mapper.Map<MenuItem>(menuItemCreateDTO);
                }
                else
                {
                    _response.IsSuccess = false;
                   
                    _response.ErrorMessages = new List<string>()
                    {
                        "Model state not valid"
                    };
                }
            }
            catch (Exception ex)
            {
              _response.IsSuccess = false;
                _response.ErrorMessages.Add(ex.Message);    
            }
            return _response;

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<ApiResponse>> UpdateMenuItem(int id,[FromForm] MenuItemUpdateDTO menuItemUpdateDTO)//using from form instead of from party because we need to upload an image when using menu items
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (menuItemUpdateDTO == null || id != menuItemUpdateDTO.Id)
                    {
                        _response.StatusCode = HttpStatusCode.BadRequest;
                        _response.IsSuccess = false;
                        return BadRequest("Cant Find ID");
                    }
                    MenuItem menuItemFromDb = await _db.MenuItems.FindAsync(id);
                    if (menuItemFromDb == null)
                    {
                        _response.StatusCode = HttpStatusCode.BadRequest;
                        _response.IsSuccess = false;
                        return BadRequest();
                    }
                    menuItemFromDb.Name=menuItemUpdateDTO.Name;
                    menuItemUpdateDTO.Id = menuItemUpdateDTO.Id;
                    menuItemFromDb.Category=menuItemUpdateDTO.Category;
                    menuItemFromDb.SpecialTag=menuItemUpdateDTO.SpecialTag; 
                    menuItemFromDb.Description=menuItemUpdateDTO.Description;

                    //if(menuItemUpdateDTO.File != null && menuItemUpdateDTO.File.Length > 0)
                    //{
                    //    string fileName = $"{Guid.NewGuid()}{Path.GetExtension(menuItemUpdateDTO.File.FileName)}";
                    //    await _blobService.DeleteBlob(menuItemFromDb.Image.Split('/').Last(), SD.SD_Storage_Container);
                    //    menuItemFromDb.Image = await _blobService.UploadBlob(fileName, SD.SD_Storage_Container, menuItemUpdateDTO.File);
                    //}
                    if (menuItemUpdateDTO.Image != null && menuItemUpdateDTO.Image.Length > 0)
                    {
                        menuItemFromDb.Image = menuItemUpdateDTO.Image;
                    }
                        _db.MenuItems.Update(menuItemFromDb);
                    _db.SaveChanges();
                    _response.StatusCode = HttpStatusCode.NoContent;
                    return Ok(_response);

                  
                }
                else
                {
                    _response.IsSuccess = false;

                    _response.ErrorMessages = new List<string>()
                    {
                        "Model state not valid"
                    };
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add(ex.Message);
            }
            return _response;

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ApiResponse>> DeleteMenuItem(int id)
        {
            try
            {

                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest("Id cannot be 0");
                }
                    MenuItem menuItemFromDb = await _db.MenuItems.FindAsync(id);
                    if (menuItemFromDb == null)
                    {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    return BadRequest("Id cannot be found");
                    }
                     //await _blobService.DeleteBlob(menuItemFromDb.Image.Split('/').Last(), SD.SD_Storage_Container);
                int milliseconds = 2000;//adding a delay of 2 seconds to the api;
                Thread.Sleep(milliseconds);
                   
                    _db.MenuItems.Remove(menuItemFromDb);
                    _db.SaveChanges();
                    _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add(ex.Message);
            }
            return _response;

        }
    
}
}
