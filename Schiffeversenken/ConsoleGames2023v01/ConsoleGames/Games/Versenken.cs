using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Principal;
using System;
using System.Linq;
using System.Reflection.Emit;
using System.ComponentModel;
using System.Drawing;

namespace ConsoleGames.Games; // here use name of your project

public class Versenken : Game
{
    // PUBLIC PROPERTIES (Eigenschaften)S
    public override string Name => "Versenken";
    public override string Description => "Erraten Sie die Position der gegnerischen Schiffe.";
    public override string Rules => "Jedes Schiff hat ein Schuss, bei einem Treffer oder nach der Runde läd es nach.";
    public override string Credits => "Keanu, kebelode@ksr.ch";
    public override int Year => 2023;
    public override bool TheHigherTheBetter => true;
    public override int LevelMax => 1;
    public override Score HighScore { get; set; }
    // No variable declarations in this area!!

    public override Score Play(int level = 1)
    {
        bool WIN = true;
        int Playerlives = 5;
        int SumPlayerBoats = 2;
        int Botlives = level+5;
        int SumBotBoats = 2;
        Display.DrawBoard();
        placeBotBoat(level);
        placePlayerBoat(ref SumPlayerBoats);
        Display.refresh("player");
        while (WIN)
        {
            while (true)
            {
                shoot(ref SumPlayerBoats);
                if (!hit)
                {
                    break;
                }
                Display.refresh(bot);
            }
            while (true)
            {
                Bot_shoot(SumBotBoats);
                if (!hit){
                    break;
                }
                Display.refresh(player);
            }
            if(Playerlives > 0) {
                WIN = false;
                
            }
            else if (Botlives > 0)
            {
                //todo: neue runde starten oder neue boote plazieren
                
            }

        }

        return new Score();
    }
    static private Point placePlayerBoat(ref int SumPlayerBoats)
    {
        
        return new Point();
    }
    static private Point placeBotBoat(ref int SumBotBoats)
    {

        return new Point();
    }
}

class Display
{
 static public void DrawBoard()
    {
        //todo: zeichne spielbrett 
    }

 static public void refresh(String BoardName) 
    {
        //todo: refresh funktion einbauen für bot-raster und player-raster
    }


}
class Cursor
{

}