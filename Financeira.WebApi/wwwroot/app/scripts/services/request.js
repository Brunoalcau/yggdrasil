'use strict';

/**
 * @ngdoc service
 * @name wwwrootApp.request
 * @description
 * # request
 * Service in the wwwrootApp.
 */
angular.module('wwwrootApp')
  .service('request', function ($http) {
    	var url = 'http://localhost:5000/api';
    	this.get = function (query) {
          var q = query ? query : '';
          return $http.get(url+'/business'+q);
        }
        this.getById = function(id){
            return $http.get(url+'/business/'+id);
        };
        this.post = function (data) {
            
            return $http.post(url+'/business', data);
        }
        this.delete = function (data) {
            console.log(data);
            return $http({
               method: 'DELETE',
               url: 'http://localhost:5000/api/business',
               data: data,
               dataType: "json",
               headers: {
                  'Content-Type': 'application/json;charset=utf-8'
               }
            });

            // return $http.delete(url+'/business', data);
        }
        this.put = function (data) {
            return $http.put(url+'/business',data);
        }
  });
