using System; 
using System.Collections.Generic;

namespace PrimeSifting.Models {
  public class Prime {
    public Prime(){}
    public List<int> CreateNumbersBetween(int number) {
       int differenceBetweenNumberAndLowestPrime = number - 2;
       List<int> numbersBetween = new List<int>();
       int lowestPrime = 2;
       numbersBetween.Add(lowestPrime);
       for(int i = 1; i <= differenceBetweenNumberAndLowestPrime; i++) {
        lowestPrime++;
        numbersBetween.Add(lowestPrime);
       }
        return numbersBetween;
     }
    public List<int> SiftNumbers(List<int> numbers, int prime, int indexOfPrime, int indexOfNext) {
        if(indexOfPrime == numbers.Count - 1) {
          return numbers;
        }
        List<int> primes = new List<int>(numbers);
        int p = prime;
        int iOP = indexOfPrime;
        int iON = indexOfNext;

        if(indexOfNext >= primes.Count) {
          p = p + 1;
          iOP = iOP + 1;
          iON = iOP + 1;
        } else if(primes[indexOfNext] % prime == 0) {
            primes.RemoveAt(indexOfNext);
            iON = iON + 1;
          } else if(primes[indexOfNext] % prime != 0){
            iON = iON + 1;
          }  
        return SiftNumbers(primes, p, iOP, iON);  
        }
  }
}

