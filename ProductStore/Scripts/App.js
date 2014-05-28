;var productApp = angular.module('ProductStore', []);
productApp.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/products', {
        templateUrl: 'products.html',
        controller: MainCtrl
    });
    $routeProvider.when('/product-detail/:productId', {
        templateUrl: 'product-detail.html',
        controller: ProductCtrl
    });
    $routeProvider.otherwise({ redirectTo: '/products' });
}]);