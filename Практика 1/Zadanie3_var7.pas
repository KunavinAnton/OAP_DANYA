Program Kabanov_3_Var7;
var N, A, B, C: integer;
begin
write('Введите кол-во учеников:');
readln(N);
write('Введите кол-во пятёрок:');
readln(A);
write('Введите кол-во четвёрок:');
readln(B);
write('Введите кол-во троек:');
readln(C);

if A+B+C = N then 
  begin
  writeln('Процент пятерок: ', A/N * 100, '%');
  writeln('Процент четверок: ', B/N * 100, '%');
  writeln('Процент троек: ', C/N * 100, '%');
  end
else
  writeln('Кол-во учеников и сумма кол-ва оценок не равны!');
end.