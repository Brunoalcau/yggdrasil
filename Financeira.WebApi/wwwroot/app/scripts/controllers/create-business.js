'use strict';

/**
 * @ngdoc function
 * @name wwwrootApp.controller:CreateBusinessCtrl
 * @description
 * # CreateBusinessCtrl
 * Controller of the wwwrootApp
 */
angular.module('wwwrootApp')
  .controller('CreateBusinessCtrl', function ($scope, request, $mdDialog, toastr, $rootScope) {
    $scope.type = 'Cadastro';
    $scope.types = [
        { id: 0, name: "Despesas" },
        { id: 1, name: "Receitas" }
    ];
    $scope.business = {};
    $scope.save = function(business){
    	request.post(business)
    	.then(function(data){
    		$rootScope.$broadcast('save-business');
    		$scope.cancel();
    		toastr.success('Salvo com sucesso', 'Sucesso!');
    	},function(err){
    		toastr.error('Ocorreu um erro', 'Erro!');
    	});
    };
    $scope.cancel = function(){
    	$mdDialog.cancel();
    };
  });
