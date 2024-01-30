using ApplicationForm.BL;
using ApplicationForm.DAL;
using ApplicationForm.DAL.Ef;
using ApplicationForm.DAL.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddSingleton<IAuthApplicationFormBL, AuthApplicationFormBL>();
builder.Services.AddSingleton<IAuthApplicationFormDAL, AuthApplicationFormDAL>();
builder.Services.AddSingleton<IShowInfomationBL, ShowInfomationBL>();
builder.Services.AddSingleton<IShowInfomationDAL, ShowInfomationDAL>();

var app = builder.Build();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.Run();


/*using (var db = new Context()) {

    Application application = new Application() {
        Name = "Googl",
    };
    Application application2 = new Application() {
        Name = "Googl2",
    };
    Application application3 = new Application() {
        Name = "Googl3",
    };

    db.applications.Add(application);
    db.applications.Add(application2);
    db.applications.Add(application3);

    db.SaveChanges();
}
*/