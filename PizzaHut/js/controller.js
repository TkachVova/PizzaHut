'use strict';

// the storeController contains two objects:
// - store: contains the pizza list
// - cart: the shopping cart object
function storeController($scope, $routeParams, DataService) {

    // get store and cart from service
    $scope.store = DataService.store;
    $scope.cart = DataService.cart;


    
    $scope.items = [];
    for (var i = 0; i < 100; i++) $scope.items.push(i);


    // use routing to pick the selected pizza
    if ($routeParams.pizzaId != null) {
        $scope.pizza = $scope.store.getPizza($routeParams.pizzaId);
    }
}
