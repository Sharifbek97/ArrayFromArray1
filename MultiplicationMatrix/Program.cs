int [][] M1= new int[4][];
var rnd = new Random();
for (var i = 0; i < M1.Length; i++)
{
    M1[i] = new int[4];
    for (var j = 0; j < M1[i].Length; j++)
    {
        M1[i][j] = rnd.Next(1, 10);
        Console.Write(M1[i][j]+"  ");
    }
    Console.WriteLine(" ");
}


Console.Write("\n");
int[][] M2 = new int[4][];
for (var i = 0; i < M2.Length; i++)
{
    M2[i] = new int[4];
    for (var j = 0; j < M2[i].Length; j++)
    {
        M2[i][j] = rnd.Next(1, 10);
        Console.Write(M2[i][j]+"  ");
    }
    Console.WriteLine(" ");
}


Console.Write("\n");
for (var i = 0; i < 4; i++)
{
    for (var j = 0; j < 4; j++)
    {
        var Mult = 0;
        for (var k = 0; k < 4; k++)
        {
            Mult+=M1[i][k] * M2[k][j];
        }
        Console.Write(Mult+ "  ");
    }
    Console.WriteLine(" ");
}