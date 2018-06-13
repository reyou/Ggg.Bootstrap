using System.Text;

namespace Bootstrap.Web.Controllers
{
    public class ViewItem
    {
        public string DirectoryName { get; set; }
        public string FileInfoName { get; set; }
        public string ApplicationName { get; set; }

        public string GetLink()
        {
           StringBuilder builder = new StringBuilder();
            builder.Append("/");
            builder.Append(ApplicationName);
            builder.Append("/");
            builder.Append(DirectoryName);
            builder.Append("/");
            builder.Append(FileInfoName);
            builder.Replace(".cshtml",string.Empty);
            return builder.ToString();
        }
    }
}