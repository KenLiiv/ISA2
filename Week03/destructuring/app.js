/*
let a, b, c;
let names = ['david', 'goliath', 'kitt'];

[a, b, c] = names;

console.log(a);
console.log(b);
console.log(c);
*/

let year, model;

({ year, model } = {
    make: 'audi',
    model: 'a4',
    year: 2020,
    value: 50
});

console.log(year);
console.log(model);