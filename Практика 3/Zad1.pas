program IF1;
var a:real;
begin
  writeln('Введите значение числа А:');
  readln(a);
  if a > 0 then
    writeln('Квадратный корень из числа: ', sqrt(a))
  else if a = 0 then
    writeln('Значение квадратного корня равняется нулю')
  else
    begin writeln('Корень из отрицательного числа не извлекается ');
  writeln('Программа завершена!'); end;
end.