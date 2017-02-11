'use strict';

describe('Controller: CreateBusinessCtrl', function () {

  // load the controller's module
  beforeEach(module('wwwrootApp'));

  var CreateBusinessCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    CreateBusinessCtrl = $controller('CreateBusinessCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(CreateBusinessCtrl.awesomeThings.length).toBe(3);
  });
});
