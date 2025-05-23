app.service("StudentJobPortalService", function ($http) {


    this.registerUser = function (jsonData) {
        var response = $http({
            method: "POST",
            url: "/JobPortal/RegisterUser",
            data: jsonData
        });
        return response;
    }






});