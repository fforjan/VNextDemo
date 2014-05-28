using Microsoft.AspNet.Builder;
using Microsoft.AspNet.FileSystems;
using Microsoft.AspNet.StaticFiles;
using Microsoft.AspNet.Http;

namespace KWebStartup
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
			// rediretion of nuget packages
			app.UseStaticFiles(new StaticFileOptions { 
				RequestPath = new PathString("/Scripts/angular"),
				FileSystem = new PhysicalFileSystem("../packages/angularjs.1.2.16/content/Scripts")});
				
			
            // enables the rediretion of / to App folder			
			app.UseStaticFiles(new StaticFileOptions { FileSystem = new PhysicalFileSystem("./App") });
			
			app.BuildTypeScript();
		}
    }
}