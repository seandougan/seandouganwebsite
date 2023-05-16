module.exports = {
    parser: '@typescript-eslint/parser',
    parserOptions: {
        ecmaVersion: 2020, // Allows for the parsing of modern ECMAScript features
        sourceType: 'module', // Allows for the use of imports
        project: './tsconfig.json',
    },
    extends: [
        'eslint:recommended',
        'plugin:@typescript-eslint/eslint-recommended',
        'plugin:@typescript-eslint/recommended', // TypeScript rules
        'plugin:@typescript-eslint/recommended-requiring-type-checking', // TypeScript rules requiring type checking
    ],
    rules: {
        // Place to specify ESLint rules. Can be used to overwrite rules specified from the extended configs
        // e.g. '@typescript-eslint/explicit-function-return-type': 'off',
        'strict': ['error', 'global'],
        'no-console': 'error', // Disallow the use of console
        'eqeqeq': 'error', // Require the use of === and !==
        'curly': 'error', // Require following the curly brace conventions for all control statements
        'no-else-return': 'error', // Disallow else after a return in an if
        'no-multi-spaces': 'error', // Disallow multiple spaces
        'no-whitespace-before-property': 'error', // Disallow whitespace before properties
        'space-infix-ops': 'error', // Require spacing around infix operators
        'space-unary-ops': 'error', // Disallow space between unary operators and their operands
        'no-var': 'error', // Require let or const instead of var
    },
};
