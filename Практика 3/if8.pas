program if8;
var a,b:real;
begin
  writeln('Введите два числа: ');
  readln(a, b);
  if a > b then
    begin
     writeln('Большее число = ', a);
     writeln('Меньшее число = ', b);
     
     readln;
    end
  else
    begin
    writeln('Большее число = ', b);
    writeln('Меньшее число = ', a);
    
    readln;
    end
end.