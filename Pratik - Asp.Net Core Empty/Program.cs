var builder = WebApplication.CreateBuilder(args);
// MVC Servislerinin eklenmesini sa�layan kod
builder.Services.AddControllersWithViews();

var app = builder.Build();
// Statik dosyalar�n kullan�lmas�n� sa�layan kod
app.UseStaticFiles();
// Routing'in etkinle�tirilmesini sa�layan kod
app.UseRouting();
// Varsay�lan routing
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");
});


app.MapGet("/", () => "Hello World!");

app.Run();


/*
 Basit A��klamalar:
 
 1. Controller:
    Kullan�c�n�n yapt��� istekleri i�ler ve hangi sayfan�n g�sterilece�ini belirler.
 
 2. Action:
    Controller i�indeki her bir i�lemi yapan fonksiyonlard�r.
 
 3. Model:
    Uygulamada kullan�lan verilerin tutuldu�u yap�lard�r.
 
 4. View:
    Kullan�c�n�n taray�c�da g�rd��� sayfad�r.
 
 5. Razor:
    HTML i�inde C# kodu yazmam�za imkan tan�r.
 
 6. RazorView:
    Razor kodlar�n�n i�lenip HTML sayfas� haline getirildi�i yerdir.
 
 7. wwwroot:
    Statik dosyalar�n (CSS, JS, resimler) sakland��� klas�rd�r.
 
 8. builder.Build():
    Uygulamay� ba�latmak i�in gerekli t�m ayarlar� yapar.
 
 9. app.Run():
    Uygulaman�n �al��mas�n� ba�lat�r ve gelen t�m istekleri kar��lar.
 */