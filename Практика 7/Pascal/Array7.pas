Program Array7;
const x = 30;
Type MyArray=Array[1..x] of real;
Var
  Arr: MyArray;
  i, n: integer;
 Begin
   Write('Введите n ');
   readln(n);
   Randomize;
   For i:= 1 to n do Arr[i] := random(30);
   For i := 1 to n do Write(Arr[i], '     ');
   writeln
   For i:=n downto 1 do Write(Arr[i], '     ');
 End.