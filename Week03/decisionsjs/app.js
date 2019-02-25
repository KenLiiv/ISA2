let count = 4;
if (count == 4) {
    console.log('count is 4');
}
let hero = 'superman';
switch (hero.toLowerCase()) {
    case 'superman':
        console.log('is superman');
        break;
    case 'batman':
        console.log('is batman');
        break;
    default:
        console.log('is hero');
}

let a = 1, b = '1';
let result = (a == b) ? 'equal' : 'not equal';
console.log(result);
//console.log(a == b) ? 'equal' : 'not equal';