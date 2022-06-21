Program Zad1;
Const n = 30;
Type MyArray=Array[1..n] of integer;
Var
  A: MyArray;
  s, i: integer;
  pos, neg: integer;
 Begin
   Writeln('Введите ', n, ' чисел');
   For i := 1 To n Do readln(A[i]);
   s:=0;
   pos = 0;
   neg:=0;
   For i:= 1 To n Do
       if A[i] > 0 then Inc(pos) Else
         if A[i] < 0 then Inc(neg);
   Writeln(pos:4, neg:4);
 End.