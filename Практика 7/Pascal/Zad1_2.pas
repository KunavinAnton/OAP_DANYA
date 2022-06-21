Program Zad1;
Const n = 30;
Type MyArray=Array[1..n] of integer;
Var
  A: MyArray;
  s, i, k: integer;
 Begin
   Writeln('Введите число k ');
   Readln(k);
   Writeln('Введите ', n, ' чисел');
   For i := 1 To n Do readln(A[i]);
   s:=0;
   For i:= 1 To n Do
       if A[i] mod k = 0 then s:= s+A[i];
   Writeln('Их сумма равна ', s);
 End.