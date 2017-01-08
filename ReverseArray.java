public class ReverseArray{

    public static void main(String[] args) {      
      int a[] = { 1 , 13, 20, 55, 15};
      int result = reverseArray(a);
      
      for(int i = 0; i < result.length; i++)
        System.out.print(result[i] + " ");
      // [15 55 20 13 1] 
    }
    
    /// Explanation (how I got it)
    // N-1 is the array's length
    // N/2 will took the first half of the array's number that will be interchanged
    // for even array's length, the array's half humber will be interchanged
    // for odd array's length, the number in the mid of the array will not need it to be interchanged
    // i -> will point to the number to be switched for the
    // N-1-i will get the number to be switched (the other half array's asimetric or correspondant number, if we split the array in two)
    // temp store the i pointed number and then is asigned to the interchanged position.
    public static int[] reverseArray(arr){
      int N = arr.length;
      for (int i = 0; i < N/2; i++) {
        int temp = arr[i];
        arr[i] = arr[N-1-i];
        arr[N-i-1] = temp;
      }
      
      return arr;
    }
}
