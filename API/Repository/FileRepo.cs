
namespace API.Repository
{
    public class FileRepo : IFileRepo
    {
        //TIÊM
        private readonly IWebHostEnvironment _environment;
        public FileRepo(IWebHostEnvironment environment) 
            {
                _environment = environment;
            }

        public async Task<string> UploadRoot(IFormFile file)
        {
            if(file == null)
            {
                return null;
            }
            var filePath=Path.Combine(_environment.WebRootPath, "uploads", file.FileName);
            using(var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            } 
            return filePath;

        }
    }
}
