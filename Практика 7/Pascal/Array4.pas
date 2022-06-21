Program Array7;
const x = 30;
Type MyArray=Array[1..x] of real;
Var
  Arr: MyArray;
  i, n: integer;
  d, a: real;
 Begin
   Writeln('Введите N = ');
   Read(N);
   Writeln('Введите A = ');
   Read(A);
   Writeln('Введите D = ');
   Read(D);
   Arr[1] := a;
   For i:= 2 to n do
    begin
     Arr[i] := round(a * power(d, i - 1), 2);
    end;
   For i := 1 to n do
     Writeln(Arr[i]);
 End.