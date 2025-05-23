app.controller("StudentJobPortalController", function ($scope, $window, StudentJobPortalService) {

    $scope.Login = function () {
        swal("Good job!", "You clicked the button!", "success")
            .then(function () {
                $window.location.href = '/JobPortal/HomePage';
            });
    };


    $scope.register = function () {

        swal("Good job!", "You clicked the button!", "success");

        var jsonData = {
            selectedRole: $scope.selectedRole,
            firstName: $scope.firstName,
            middleName: $scope.middleName,
            lastName: $scope.lastName,
            contactNumber: $scope.contactNumber,
            emailAddress: $scope.emailAddress,
            password: $scope.password,
            program: $scope.program,
            companyName: $scope.companyName,
            industry: $scope.industry
        }

        var saveData = StudentJobPortalService.registerUser(jsonData);
        saveData.then(function (parameter) {
            alert(parameter.data)
        });
    }

});



//public String FirstName { get; set; }
//        public String MiddleName { get; set; }
//		public String LastName { get; set; }
//        public String ContactNumber { get; set; }
//        public String EmailAddress { get; set; }
//        public String Password { get; set; }