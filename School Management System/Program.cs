using Microsoft.EntityFrameworkCore;
using School_Management_System.Models;
using School_Management_System.Models.TeacherModel;
using schoolmanagementsystem.Models.StudentModel;
using School_Management_System.Models.ViewModels;
using School_Management_System.Models.ClassesModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();

builder.Services.AddScoped<IClassesRepository , ClassesRepository>();


builder.Services.AddDbContext<SchoolManagementDbContext>(options => {
    options.UseNpgsql(
        builder.Configuration["ConnectionStrings:SchoolManageConnection"]);
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
