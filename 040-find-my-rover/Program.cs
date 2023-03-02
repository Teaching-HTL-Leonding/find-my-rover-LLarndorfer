//*Lukas Larndorfer
//*Find my Rover
//TODO: Level 3 (failed)
//TODO: Try Level 4

#region define variables
int x = 0;
int y = 0;
int manhattendistance = 0;
string xdirection;
string ydirection;
string movement;
Console.Write("Enter the Movement: ");
movement = Console.ReadLine()!;
movement.Replace(" ", "");
char[] ch = { 'V', '^', '<', '>' }; // Useless rn
#endregion





int Calculateandprint(string movement)
{
    for (int i = 0; i < movement.Length; i += 2) // + 2 cuz of Direction + Times
    {
        switch (movement[i])
        {
            case '>': //East
                x += int.Parse(movement.Substring(i + 1, 1));
                break;

            case '<': //West
                x -= int.Parse(movement.Substring(i + 1, 1));
                break;

            case '^': //North
                y += int.Parse(movement.Substring(i + 1, 1));
                break;

            case 'V': //South
                y -= int.Parse(movement.Substring(i + 1, 1));
                break;
        }
    }

    
    if (x > 0)
    {
        xdirection = "East";
    }
    else
    {
        xdirection = "West";
        x = x * (-1);
    }
    if (y > 0)
    {
        ydirection = "North";
    }
    else
    {
        ydirection = "South";
        y = y * (-1);
    }

    manhattendistance = x + y;

    double lineardistance = Math.Sqrt(x * x + y * y); //Sentece of Pythagoras
    if (x == 0 && y == 0)
    { System.Console.WriteLine("The rover is in the base station"); }
    else
    {
        System.Console.WriteLine($"You went {x} {xdirection} and {y} {ydirection}. Manhatten Distance: {manhattendistance}. \nLinear Distance {lineardistance} ");
    }
    return y;
}

Calculateandprint(movement);
