
int ax = 40, ay =  1,
    bx = 1, by= 30,
    cx = 81, cy = 30;


Console.SetCursorPosition(ax,ay);
Console.Write("+");

Console.SetCursorPosition(bx,by);
Console.Write("+");

Console.SetCursorPosition(cx,cy);
Console.Write("+");

int x = ax; 
int y = ay;
int count = 0;
string symb = "#";

while(count<10000)
{
    int what  = new Random().Next(0,3);
    if(what==0)
    {
        x=(x+ax)/2;
        y=(y+ay)/2;
        symb = "*";
    }

    if(what==1)
    {
        x=(x+bx)/2;
        y=(y+by)/2;
        symb = "+";
    }

    if(what==2)
    {
        x=(x+cx)/2;
        y=(y+cy)/2;
        symb = "#";
    }

Console.SetCursorPosition(x,y);
Console.Write(symb);
count++;
}
