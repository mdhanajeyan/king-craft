//# sourceURL=route-resolver-provider.js
(function () {
    angular.module("KingCraft.Providers")
        .provider("routeResolver", function () {
            this.$get = function () {
                return this;
            };
            this.route = function () {
                var resolveRoute = function (routeHtml, routeDependencies) {
                    return {
                        templateUrl: routeHtml,
                        resolve: {
                            deps: ["$q", "$rootScope", function ($q, $rootScope) {
                                var deferred = $q.defer();
                                if (angular.isDefined(routeDependencies)) {
                                    routeDependencies.forEach(function (dep) {
                                        require(dep);
                                    });
                                }
                                deferred.resolve();

                                return deferred.promise;
                            }]
                        }
                    }
                };

                return {
                    resolveRoute: resolveRoute
                };
            };

        })
})();
function require(jsScript) {
    $("head").append("<script src=" + jsScript + "></script>");
}
//# sourceURL=route-resolver-provider.js