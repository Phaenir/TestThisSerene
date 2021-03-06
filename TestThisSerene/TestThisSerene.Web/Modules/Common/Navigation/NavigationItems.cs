﻿using Serenity.Navigation;
using Administration = TestThisSerene.Administration.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "icon-speedometer")]
[assembly: Serenity.Navigation.NavigationMenu(2000, "Movie Database", icon: "icon-film")]
[assembly: Serenity.Navigation.NavigationLink(2100, "Movie Database/Movies", typeof(TestThisSerene.MovieDB.Pages.MovieController), icon: "icon-camrecorder")]
[assembly: Serenity.Navigation.NavigationLink(2200, "Movie Database/Genre", typeof(TestThisSerene.MovieDB.Pages.GenreController), icon:"icon-pin")]
[assembly: NavigationMenu(9000, "Administration", icon: "icon-screen-desktop")]
[assembly: NavigationLink(9000, "Administration/Exceptions Log", url: "~/errorlog.axd", permission: TestThisSerene.Administration.PermissionKeys.Security, icon: "icon-ban", Target = "_blank")]
[assembly: NavigationLink(9000, "Administration/Languages", typeof(Administration.LanguageController), icon: "icon-bubbles")]
[assembly: NavigationLink(9000, "Administration/Translations", typeof(Administration.TranslationController), icon: "icon-speech")]
[assembly: NavigationLink(9000, "Administration/Roles", typeof(Administration.RoleController), icon: "icon-lock")]
[assembly: NavigationLink(9000, "Administration/User Management", typeof(Administration.UserController), icon: "icon-people")]