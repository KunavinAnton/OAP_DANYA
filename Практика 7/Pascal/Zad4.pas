Program Zad1;
Const n = 10;
Type MyArray=Array[1..n] of integer;
Var
  A, B: MyArray;
  i, j: integer;
 Begin
   Writeln('Введите ', n, ' чисел');
   For i := 1 To n Do readln(A[i]);
   j:=0;
   For i:= 1 To n Do
       if A[i] mod 2 = 0 then 
        begin
         Inc(j);
         B[j] := i;
        end;
   For i:= 1 To j Do
     Write(B[i]:3);
   Writeln;
 End.