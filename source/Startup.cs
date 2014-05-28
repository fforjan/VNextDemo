using Microsoft.AspNet.Builder;
using Microsoft.AspNet.FileSystems;
using Microsoft.AspNet.StaticFiles;

namespace KWebStartup
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
			// enables the rediretion of / to App folder
			app.UseStaticFiles(new StaticFileOptions { FileSystem = new PhysicalFileSystem("./App") });
			app.BuildTypeScript();
		}
    }
}