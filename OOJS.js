

//const object----An object declared as const can be changed
const user = {
  name: "John"
};

user.age = 25; // (*)

alert(user.age); // 25

const user = {
  name: "John"
};

// Error (can't reassign user)
user = {
  name: "Pete"
};

//cloning and merging,Object.Assign
let user = {
  name: "John",
  age: 30
};

let clone = {}; // the new empty object

// let's copy all user properties into it
for (let key in user) {
  clone[key] = user[key];
}

// now clone is a fully independent clone
clone.name = "Pete"; // changed the data in it

alert( user.name ); // still John in the original object

