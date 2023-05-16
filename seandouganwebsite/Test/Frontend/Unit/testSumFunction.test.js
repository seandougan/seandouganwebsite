const testSumFunction = require("../../../src/ts/testSumFunction");

test('adds 1 + 2 to equal 3', () => {
    expect(testSumFunction(1, 2)).toBe(3);
});