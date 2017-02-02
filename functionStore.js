

// creating a store of unique functions
var store = {
  nextId: 1,
  cache: {},
  add: function(fn) {
    if (!fn.id) {
      fn.id = this.nextId++;
      this.cache[fn.id] = fn
      return true
    }
  }
}

/*

function ninja() {}

console.log("Empty store", store);

store.add(ninja);

console.log("storing a function", store);


store.add(ninja);

console.log("trying to store the same function", store);


*/
