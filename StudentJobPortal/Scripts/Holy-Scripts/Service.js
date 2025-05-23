app.service("StudentJobPortalService", function ($http) {


    this.register = function (jsonData) {
        var response = $http({
            method: "POST",
            url: "/JobPortal/RegisterUser",
            data: jsonData
        })
        return response;
    }






});