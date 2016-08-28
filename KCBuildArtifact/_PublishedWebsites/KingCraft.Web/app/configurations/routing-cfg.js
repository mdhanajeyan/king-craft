//#sourceURL =routing-cfg.js
(function () {
    angular.module("KingCraft.Configurations")
        .config(["$routeProvider", "$controllerProvider", "routeResolverProvider", "$provide",
            function ($routeProvider, $controllerProvider, routeResolverProvider, $provide) {

                //to dynamically load controllers, the following line of code is necessary
                angular.module("KingCraft.Controllers").controller = $controllerProvider.register;

                //to dynamically load services, the following line of code is necessary
                angular.module("KingCraft.Services").service = $provide.service;

                //to dynamically load factories, the following line of code is necessary
                angular.module("KingCraft.Services").factory = $provide.factory;

                var route = routeResolverProvider.route();

                $routeProvider
                    .when("/", route.resolveRoute("app/dashboard/dashboard.html", ["app/dashboard/dashboard-ctrl.js"]))
                    .when("/login", route.resolveRoute("app/login/login.html", ["app/login/login-svc.js", "app/login/login-ctrl.js"]))
                    .otherwise({
                        redirectTo: "/"
                    });
            }]);
})();
//#sourceURL =routing-cfg.js