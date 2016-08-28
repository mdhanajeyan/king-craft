//#sourceURL=app.js

(function () {

    angular.module("KingCraft.Providers", []);

    angular.module("KingCraft.Configurations", []);

    angular.module("KingCraft.Directives", []);

    angular.module("KingCraft.Models", []);

    angular.module("KingCraft.Services", ["KingCraft.Models"]);

    angular.module("KingCraft.Controllers", ["KingCraft.Models", "KingCraft.Services"]);

    angular.module("KingCraft", ["KingCraft.Providers", "KingCraft.Configurations",
                                    "KingCraft.Directives", "KingCraft.Models",
                                    "KingCraft.Services", "KingCraft.Controllers"]);
})();


//#sourceURL=app.js