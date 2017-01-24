public class MathFuctions{
    public static void main(String[] args) {
      int number = 5
      if (isPrime(number)) {
        System.out.print("The number " + number + "is Prime");
      } else {
        System.out.print(number + " is not Prime")
      }
    }

    // explanation
    // A prime number is only divisible by one or by itself
    public static boolean isPrime(int N)
    {

      // 1 is prime by default
      if (N < 2) return false;

      // all the pow of 2 of any number is not a prime number
      // (cold be divide by 2 or any pow of 2)
                          // QUESTION why EQUAL is used at the condition
      for (int i = 2; i*i <= N; i++)
                        // the modulos of the number denotes tha has multiple divisors,
                        // so stop de iteration and return false;
        if (N % i == 0) return false;

      // as the value does not have another divisor, then is a prime number   
      return true;
    }
}
