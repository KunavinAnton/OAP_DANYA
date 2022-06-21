Program Zad1;
Const n = 7;
Type MyArray=Array[1..n] of integer;
Var
  A: MyArray;
  i: integer;
 Begin
   Writeln('Ввод элементов массива. Не забудьте об отрицательных элементах ');
   For i := 1 To n Do read(A[i]);
   Writeln('Вывод отрицательных элементов и их номеров');
   For i:= 1 To n Do
     if A[i] < 0 Then Writeln(A[i], ' ', i, ' ');
 End.