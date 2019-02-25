let number = 5;
let stringNumber = '8';
stringNumber = parseInt(stringNumber, 10);
let result = number + stringNumber;
console.log('Result: ' + result);

let nonParsable = parseInt('no');
let boolParsable = isNaN(nonParsable);
console.log('Is no not parsable: ' + boolParsable);
