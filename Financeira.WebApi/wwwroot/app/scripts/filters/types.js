'use strict';

/**
 * @ngdoc filter
 * @name wwwrootApp.filter:types
 * @function
 * @description
 * # types
 * Filter in the wwwrootApp.
 */
angular.module('wwwrootApp')
  .filter('types', function () {
    return function (item) {
       return item ? 'Receitas' : 'Despesas';
    }
  });
