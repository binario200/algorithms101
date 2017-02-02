var values = [0, 3, 2, 5, 7, 4, 8, 1];

console.log("array before sorting ", values.join(" "));


// returns a positive number is the order of the 
// passed values should be reversed
// returns negative number if not
/// returns zero if the vales are equal
values.sort(function(value1, value2){
  return value1 - value2;
});

console.log("array after sorting ", values.join(" "));
