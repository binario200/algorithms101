public class ReverseArray{

    public static void main(String[] args) {      
      int a[] = { 1 , 13, 20, 55, 15};
      int result = reverseArray(a);
      
      for(int i = 0; i < result.length; i++)
        System.out.print(result[i] + " ");
      // [15 55 20 13 1] 
    }
    
    
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
