'use strict';


app.controller('homeController', ['$scope', 'pizzaListService', function ($scope, pizzaListService) {
    $scope.message = "Pizza list";
    $scope.pizzaList = {
        PizzaId: "",
        PizzaName: "",
        PizzaIngridients: "",
        PizzaPrice: ""
    };

    pizzaListService.getPizzaList($scope);
}
])

app.service('pizzaListService', ['$http', function ($http) {
    this.getPizzaList = function ($scope) {
        return $http({
            method: "GET",
            url: "../api/pizzas",
            headers: { 'Content-Tipe': 'application/json' }
        }).success(function (data) {
            $scope.pizzaList = data;
            console.log(data);
        }).error(function (data) {
            console.log(data);
        });;
    };
}
]);