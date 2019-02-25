function sayHello(name) {
    return function () {
        console.log('howdy ' + name);
    }
}

let gunnar = sayHello('gunnar');
let conrad = sayHello('conrad');
gunnar();
conrad();
