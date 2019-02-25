let name = 'gunnar';
console.log(`hi ${name}`);

function getReasonCount() { return 2; }

let interpolation = `Give me ${(getReasonCount() == 1) ? 'one good reason' : 'a few reasons'} to try this`;
console.log(interpolation);