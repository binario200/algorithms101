/*
http://stackoverflow.com/questions/1187518/javascript-array-difference

// Having two arrays
// var a = ['a', 'b'];
// var b = ['a', 'b', 'c', 'd'];
// get an array tha contains the arrays difference, this is:
// var c = ['c', 'd'];
*/


function arrayDiference(a,b) {
  var c = [];
  var arrayBSet = new Set(b);
  var c = [...new Set([...a].filter(element => !arrayBSet.has(element)))];
  
  return c;
}
