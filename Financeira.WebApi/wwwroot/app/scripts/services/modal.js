'use strict';

/**
 * @ngdoc service
 * @name wwwrootApp.modal
 * @description
 * # modal
 * Service in the wwwrootApp.
 */
angular.module('wwwrootApp')
  .service('modal', function ($mdDialog) {
    return {
    	business: function(){
    		var confirm = $mdDialog.confirm({
    			controller: 'CreateBusinessCtrl',
    			templateUrl: 'views/create-business.html',
    			parent: angular.element(document.body)
    		});
    		$mdDialog.show(confirm);
    	}
    }
  });
