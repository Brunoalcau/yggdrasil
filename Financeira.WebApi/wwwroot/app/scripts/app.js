'use strict';

/**
 * @ngdoc overview
 * @name wwwrootApp
 * @description
 * # wwwrootApp
 *
 * Main module of the application.
 */
angular
  .module('wwwrootApp', [
    'ngAnimate',
    'ngAria',
    'ngCookies',
    'ngMessages',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch',
    'ngMaterial',
    'md.data.table',
    'toastr'
  ])
  .config(function ($routeProvider, $mdDateLocaleProvider) {
     $mdDateLocaleProvider.formatDate = function (date) {
            return moment(date).format('DD/MM/YYYY');
      };
      $mdDateLocaleProvider.parseDate = function (dateString) {
          var m = moment(dateString, 'DD/MM/YYYY', true);
          return m.isValid() ? m.toDate() : new Date(NaN);
      };
    $routeProvider
      .when('/', {
        templateUrl: 'views/business.html',
        controller: 'BusinessCtrl',
        controllerAs: 'business'
      })
      .when('/create-business', {
        templateUrl: 'views/create-business.html',
        controller: 'CreateBusinessCtrl',
        controllerAs: 'createBusiness'
      })
      .otherwise({
        redirectTo: '/'
      });
  });
