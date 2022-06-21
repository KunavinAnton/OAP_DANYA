Program Array4;
Type MyArray=Array[1..n] of real;
Var
  Arr: MyArray;
  i, n: integer;
  d, a: real;
 Begin
   Writeln('Введите N = ');
   Read(N);
    Writeln('Введите D = ');
   Read(D);
   Arr[1] = a;
   For i:= 2 to n do
    begin
     Arr[i] = a * power(d, i - 1);
    end;
 End.