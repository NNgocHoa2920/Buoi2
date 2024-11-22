
namespace API.Repository
{
    public interface IFileRepo
    {
        Task<string> UploadRoot(IFormFile file);
    }
}
