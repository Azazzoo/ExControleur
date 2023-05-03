using Microsoft.AspNetCore.Mvc;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();  // Relier les view au controllers
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// Configurer les routes : format URL
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=Welcome}/{action=WelcomeDefault}/{id?}"
);
// Configurer les routes : format URL
app.MapControllerRoute(
 name: "default",
 pattern: "{controller=home}/{action=index}/{id?}"
);

app.MapControllerRoute(
name: "default",
// Pattern : structure de l'URL : peut contenir le controlleur, la methode d'action et les parametres
pattern: "/{nom?}/{prenom?}",
// default : indiquer le controleur et la methode d'action par default
defaults: new { controller = "Welcome" , action = "WelcomeName"}
);

app.Run();
