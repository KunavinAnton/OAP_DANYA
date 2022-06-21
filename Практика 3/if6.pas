program if6;
var a,b:real;
begin
  writeln('Введите два числа: ');
  readln(a, b);
  if a > b then
    begin
     writeln('Большее число = ', a);
     readln;
     end
  else
    begin
    writeln('Большее число = ', b);
    readln;
    end
end.