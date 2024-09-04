var builder = WebApplication.CreateBuilder(args);
// MVC Servislerinin eklenmesini saðlayan kod
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Statik dosyalarýn kullanýlmasýný saðlayan kod
app.UseStaticFiles();
// Routing'in etkinleþtirilmesini saðlayan kod
app.UseRouting();
// Varsayýlan routing
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");
});


app.MapGet("/", () => "Hello World!");

app.Run();


/*
 Basit Açýklamalar:
 
 1. Controller:
    Kullanýcýnýn yaptýðý istekleri iþler ve hangi sayfanýn gösterileceðini belirler.
 
 2. Action:
    Controller içindeki her bir iþlemi yapan fonksiyonlardýr.
 
 3. Model:
    Uygulamada kullanýlan verilerin tutulduðu yapýlardýr.
 
 4. View:
    Kullanýcýnýn tarayýcýda gördüðü sayfadýr.
 
 5. Razor:
    HTML içinde C# kodu yazmamýza imkan tanýr.
 
 6. RazorView:
    Razor kodlarýnýn iþlenip HTML sayfasý haline getirildiði yerdir.
 
 7. wwwroot:
    Statik dosyalarýn (CSS, JS, resimler) saklandýðý klasördür.
 
 8. builder.Build():
    Uygulamayý baþlatmak için gerekli tüm ayarlarý yapar.
 
 9. app.Run():
    Uygulamanýn çalýþmasýný baþlatýr ve gelen tüm istekleri karþýlar.
 */