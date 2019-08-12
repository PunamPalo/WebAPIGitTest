var app = angular.module("myApp", []);
$scope.ButtonClick = function () {
    alert('hy');
    var productname = document.getElementById("txtProducts");
    
      
        $http({
            method: "post",
            url: "/Product/CalculateAmount",
            datatype: "json",
            data: JSON.stringify(productname)
        })
    }
}