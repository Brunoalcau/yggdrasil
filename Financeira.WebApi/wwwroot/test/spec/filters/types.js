'use strict';

describe('Filter: types', function () {

  // load the filter's module
  beforeEach(module('wwwrootApp'));

  // initialize a new instance of the filter before each test
  var types;
  beforeEach(inject(function ($filter) {
    types = $filter('types');
  }));

  it('should return the input prefixed with "types filter:"', function () {
    var text = 'angularjs';
    expect(types(text)).toBe('types filter: ' + text);
  });

});
