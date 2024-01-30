using ApplicationForm.BL;
using ApplicationForm.DAL;
using ApplicationForm.DAL.Ef;
using ApplicationForm.DAL.Model;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

using (var db = new Context()) {
    if (db.applications.Count() == 0) {
        Application application = new Application() {
            Name = "Google",
        };
        Application application2 = new Application() {
            Name = "Google2",
        };
        Application application3 = new Application() {
            Name = "Google3",
        };
        db.applications.Add(application);
        db.applications.Add(application2);
        db.applications.Add(application3);
        db.SaveChanges();
        var appRequests = new ApplicationRequest { 
            Title = "1",
            Description = "11",
            Deadline = "15.01.1999",
            Email = "trofim.chuchuk@mail.ru",
            Application=application3
        };
        List< ApplicationRequest> applicationRequest=new List< ApplicationRequest>();
        for (int i = 0;i<15;i++) {
            appRequests.Title=i.ToString();
            applicationRequest.Add(appRequests);
        }
      
        db.requests.AddRange(applicationRequest);
        db.SaveChanges();
    }
}


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


