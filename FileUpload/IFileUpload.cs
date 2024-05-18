namespace dotnetblog.FileUpload
{
    public interface IFileUpload
    {
        public Task<string> UploadFileAsync(IFormFile file);
    }
}
