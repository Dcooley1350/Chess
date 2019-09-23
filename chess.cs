using System;

class Queen
{
    static void CheckAttackable (float xQueen, float yQueen, float xPiece, float yPiece)
    {
        if (xQueen == xPiece)
        {
            Console.WriteLine("Your chess piece is attackable due to x axis");
        }
        else if ( yQueen == yPiece)
        {
            Console.WriteLine("Your chess piece is attackable due to y axis");
        }
        else if (Math.Abs(xQueen - xPiece) == (Math.Abs(yQueen - yPiece)))
        {
            Console.WriteLine("Your chess piece is attackable");
        }
        else
        {
            Console.WriteLine("Your Piece is not attackable");
        }
    }
  static void Main()
  {
    Console.WriteLine("What is the  x coordinate of the Queen?");
    string queenXString = Console.ReadLine();
    float queenX = Convert.ToSingle(queenXString);
    Console.WriteLine("What is the  y coordinate of the Queen?");
    string queenYString = Console.ReadLine();
    float queenY = Convert.ToSingle(queenYString);
    Console.WriteLine("What is the  x coordinate of the other chess piece?");
    string pieceXString = Console.ReadLine();
    float pieceX = Convert.ToSingle(pieceXString);
    Console.WriteLine("What is the  y coordinate of the other chess piece?");
    string pieceYString = Console.ReadLine();
    float pieceY = Convert.ToSingle(pieceYString);
    CheckAttackable(queenX, queenY, pieceX, pieceY);
  }
}
