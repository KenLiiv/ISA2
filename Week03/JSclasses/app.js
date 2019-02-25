class Car {
    constructor(make, model, year) {
        this.make = make;
        this.model = model;
        this.year = year;
    }

    printInfo() {
        console.log(`${this.make} ${this.model} (${this.year})`);
    }
}

let myCar = new Car('audi', 'a4', 2019);

myCar.printInfo();
/*
let car = class {

}
*/

class SportsCar extends Car {
    revEngine() {
        console.log(this.model + ' uriseb');
    }
}

let mySportsCar = new SportsCar('sporty audi', 's4', 2020);
mySportsCar.printInfo();
mySportsCar.revEngine();