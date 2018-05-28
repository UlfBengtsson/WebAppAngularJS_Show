var app = angular.module('AngJS', []);

app.service('CarsService', function ($http) {
    this.carList = function carList() {
        return $http.get("/Home/CarList"); 
    };
});