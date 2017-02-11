'use strict';

/**
 * @ngdoc function
 * @name wwwrootApp.controller:BusinessCtrl
 * @description
 * # BusinessCtrl
 * Controller of the wwwrootApp
 */
angular.module('wwwrootApp')
  .controller('BusinessCtrl', function ($scope, request, modal, toastr, $mdSidenav) {  		
	    $scope.selected = [];
        $scope.filterObj = {
        	isGroup: true
        };
        $scope.types = [
            { id: 0, name: "Despesas" },
            { id: 1, name: "Receitas" }
        ];
    	$scope.init = function(){
		 	request.get()
            .then(function (res) {
                $scope.business = res.data;
            }, function (err) {
                console.log(err);
            });
    	};
    	$scope.$on('save-business', function(event, args) {
    		$scope.init();
		});

    	$scope.modalSave = function(){
    		modal.business();
    	};

    	$scope.delete = function(business){
    		console.log(business);
    		request.delete(business).then(
			function(data){
				console.log(data);
				$scope.init();
				$scope.selected = [];
				toastr.success('Dados deletados com sucesso', 'Sucesso!')
			},
    		function(err){
    			console.log(err);
    			toastr.error('Ocorreu um erro tente novamente', 'Erro!');
    		});
    	};        
        $scope.openRightMenu = function(id) {
            request.getById(id)
            .then(function(res){
            	res.data.date = new Date(res.data.date);
            	$scope.businessEdit = res.data;
            },function(){
            	toastr.error('Ocorreu um erro tente novamente', 'Erro!');
            })
            $mdSidenav('right').toggle();
        };

        $scope.edit = function(businessEdit){
            request.put(businessEdit)
            .then(function(data){
                console.log(data);
                toastr.success('Editar item com sucesso', 'Sucesso!');
                $mdSidenav('right').close();
            },function(){
                toastr.error('Ocorreu um erro tente novamente', 'Erro!');
            })
        };
        $scope.filter = function(data){
        	var query = '';
        	var obj = Object.assign({}, data);
        	Object.keys(obj).forEach(function(item, $index){
        		if(data[item] !== undefined){
        			if(item === 'start' || item === 'end') {
        				obj[item] = moment(obj[item]).format('YYYY-MM-DD');
        			}
        			query += $index === 0 ? '?' + item + '=' + obj[item]:'&' + item + '=' + obj[item]; 
        		}
        	});
        	request.get(query)
        	.then(function(res){
        			$scope.business = res.data;
        		 },
        		 function(err){
        		 	console.log(err);
    				toastr.error('Ocorreu um erro tente novamente', 'Erro!');
        		});
        };
  });
