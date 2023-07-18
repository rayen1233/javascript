//How Edabit Works
function hello() {
	return "hello edabit.com"
}
//Convert Minutes into Seconds
function convert(minutes) {
    return minutes * 60;
  }
  
  console.log(convert(5));  
  console.log(convert(3));  
  console.log(convert(2));  
//Return the Sum of Two Numbers
function addition(a, b) {
    return a + b;
  }
  
  console.log(addition(3, 2));    
  console.log(addition(-3, -6));  
  console.log(addition(7, 3));    
//Return the Next Number from the Integer Passed
function addition(num) {
    return num + 1;
  }
  
  console.log(addition(0));   
  console.log(addition(9));   
  console.log(addition(-3));  
//Convert Age to Days
function calcAge(ageInYears) {
    return ageInYears * 365;
  }
  
  console.log(calcAge(65));  
  console.log(calcAge(0));   
  console.log(calcAge(20));  
//Power Calculator
function circuitPower(voltage, current) {
    return voltage * current;
  }
  
  console.log(circuitPower(230, 10));   
  console.log(circuitPower(110, 3));    
  console.log(circuitPower(480, 20));  
  //Area of a Triangle
  function triArea(base, height) {
    return (base * height) / 2;
  }
  console.log(triArea(3, 2));   
  console.log(triArea(7, 4));  
  console.log(triArea(10, 10)); 
//Return the Remainder from Two Numbers
function remainder(a, b) {
    return a % b;
  }
  console.log(remainder(1, 3));    
  console.log(remainder(3, 4));   
  console.log(remainder(-9, 45)); 
  console.log(remainder(5, 5));    
  //How Much is True?
  using System;

  public class Program
  {
      public static int CountTrue(bool[] arr)
      {
          int count = 0;
          foreach (bool value in arr)
          {
              if (value == true)
              {
                  count++;
              }
          }
          return count;
      }
  
      public static void Main()
      {
          bool[] arr1 = new bool[] { true, false, false, true, false };
          bool[] arr2 = new bool[] { false, false, false, false };
          bool[] arr3 = new bool[] { };
  
          Console.WriteLine(CountTrue(arr1));  // Output: 2
          Console.WriteLine(CountTrue(arr2));  // Output: 0
          Console.WriteLine(CountTrue(arr3));  // Output: 0
      }
  }
//Bitwise Operations
function bitwiseAND(a, b) {
  return a & b;
}

function bitwiseOR(a, b) {
  return a | b;
}

function bitwiseXOR(a, b) {
  return a ^ b;
}

console.log(bitwiseAND(7, 12));   // Output: 4
console.log(bitwiseOR(7, 12));    // Output: 15
console.log(bitwiseXOR(7, 12));   // Output: 11
//Correct the Mistakes
function squared(b) {
  return b * b;
}

console.log(squared(5));     // Output: 25
console.log(squared(9));     // Output: 81
console.log(squared(100));   // Output: 10000
//Add up the Numbers from a Single Number
function addUp(num) {
  let sum = 0;
  for (let i = 1; i <= num; i++) {
    sum += i;
  }
  return sum;
}
console.log(addUp(4));    
console.log(addUp(13));   
console.log(addUp(600));   
//Return Something to Me!
function giveMeSomething(a) {
  return "something " + a;
}

console.log(giveMeSomething("is better than nothing")); 
console.log(giveMeSomething("Bob Jane"));               
console.log(giveMeSomething("something"));               
//Basketball Points
function points(twoPointers, threePointers) {
  return (twoPointers * 2) + (threePointers * 3);
}

console.log(points(1, 1));   
console.log(points(7, 5));   
console.log(points(38, 8)); 
//Buggy Code (Part 5)
function printArray(number) {
  var newArray = [];
  
  for (var i = 1; i <= number; i++) {
    newArray.push(i);
  }
  
  return newArray;
}

console.log(printArray(1));  
console.log(printArray(3));   
console.log(printArray(6));   
//Tile Teamwork Tactics
function possibleBonus(a, b) {
  if (a === b) {
    return false;
  }

  if (a < b && a + 6 >= b) {
    return true;
  }

  return false;
}
console.log(possibleBonus(3, 7));  
console.log(possibleBonus(1, 9));   
console.log(possibleBonus(5, 3));   
//Convert Hours into Seconds
function howManySeconds(hours) {
  return hours * 3600;
}

console.log(howManySeconds(2));  
console.log(howManySeconds(10));  
console.log(howManySeconds(24));  
//Buggy Code (Part 1)
function cubes(a) {
  return Math.pow(a, 3);
}

console.log(cubes(3));   
console.log(cubes(5));  
console.log(cubes(10));  
//Return the Next Number from the Integer Passed
function addition(num) {
  return num + 1;
}
console.log(addition(0));   
console.log(addition(9));   
console.log(addition(-3));  
//Make a Circle with OOP
class Circle {
  constructor(radius) {
    this.radius = radius;
  }

  getArea() {
    return Math.PI * Math.pow(this.radius, 2);
  }

  getPerimeter() {
    return 2 * Math.PI * this.radius;
  }
}

let circy = new Circle(11);
console.log(circy.getArea());       

let circy2 = new Circle(4.44);
console.log(circy2.getPerimeter()); 
//Triangular Number Sequence
function triangle(n) {
  return (n * (n + 1)) / 2;
}

console.log(triangle(1));   
console.log(triangle(6));   
console.log(triangle(215));  



  