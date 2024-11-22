
using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileRepo _fileRepo;
        public FileController(IFileRepo fileRepo) { _fileRepo = fileRepo; }

        [HttpPost("uploadroot")]
        public async Task<IActionResult> UploadRoot(IFormFile file)
        {
            var filePath= await _fileRepo.UploadRoot(file);

            if(string.IsNullOrEmpty(filePath))

            {
                return BadRequest("upload failed");
            }    
            return Ok(filePath);
        }
    }
}
