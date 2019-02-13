// assignment =
// matemaatilised + - * /


let a = 1;
a++;
console.log(a); // 2, sama nagu c#
console.log(a++); // naitab a, siis liidab
console.log(++a); // liidab, siis naitab

//precedence

var b = 1 + 2 * 3; // enne korrutab
console.log(b);
b = (1 + 2) * 3;
console.log(b); // enne liidab
