/*
function first() {
    return this;
}

console.log(first() === global);

function second() {
    'use strict';
    return this;
}

console.log(second() === global);
*/
/*
let myObject = { value: 'my object' };

global.value = 'global object';

function third() {
    return this.value;
}

console.log(third());

console.log(third.call(myObject));
console.log(third.apply(myObject));
*/

function fifth() {
    console.log(this.firstName + ' ' + this.lastName);
}

let customer1 = {
    firstName: 'custo',
    lastName: 'mer1',
    print: fifth
}
let customer2 = {
    firstName: 'custo',
    lastName: 'mer2',
    print: fifth
}

customer1.print();
customer2.print();