using System;
using System.Collections.Generic;
using System.Text;

namespace Dismantle.Core.Constants
{
    public class FilmConstants
    {
        // Key States
        public const string KeyState_NotFound = "Not Found";
        public const string KeyState_Invalid = "Invalid Key";

        // Medium Types
        public const string MediumType_DVD = "DVD";
        public const string MediumType_BD = "BD";
        public static List<string> MediumTypes = new List<string>()
        {
            MediumType_BD,
            MediumType_DVD
        };

        // Roles
        public const string Role_Actor = "Actor";
        public const string Role_Composer = "Composer";
        public const string Role_Director = "Director";
        public const string Role_Writer = "Scriptwriter";
        public static List<string> RoleNames = new List<string>()
        {
            Role_Actor,
            Role_Composer,
            Role_Director,
            Role_Writer
        };

        // Locations
        public const string Location_Left = "Left Drawer";
        public const string Location_Right = "Right Drawer";
        public const string Location_Left1 = "Left DVD Rack Leve1";
        public const string Location_Left2 = "Left DVD Rack Leve2";
        public const string Location_Left3 = "Left DVD Rack Leve3";
        public const string Location_Left4 = "Left DVD Rack Leve4";
        public const string Location_Right1 = "Right DVD Rack Leve1";
        public const string Location_Right2 = "Right DVD Rack Leve2";
        public const string Location_Right3 = "Right DVD Rack Leve3";
        public const string Location_Right4 = "Right DVD Rack Leve4";
        public const string Location_Top = "Commode top drawer";
        public const string Location_Middle = "Commode middle drawer";
        public const string Location_Bottom = "Commode bottom drawer";
        public const string Location_BD1 = "BD Rack Level1";
        public const string Location_BD2 = "BD Rack Level2";
        public const string Location_BD3 = "BD Rack Level3";
        public const string Location_BD4 = "BD Rack Level4";
        public const string Location_Shelf1 = "Bedroom bookshelf1";
        public static List<string> LocationNames = new List<string>()
        {
            Location_Left,
            Location_Left1,
            Location_Left2,
            Location_Left3,
            Location_Left4,
            Location_Right,
            Location_Right1,
            Location_Right2,
            Location_Right3,
            Location_Right4,
            Location_Bottom,
            Location_Middle,
            Location_Top,
            Location_Middle,
            Location_BD1,
            Location_BD2,
            Location_BD3,
            Location_BD4,
            Location_Shelf1
        };





        // Colors
        public const string FontColor_Black = "Black";
        public const string FontColor_Blue = "Blue";
        public const string FontColor_Green = "Green";
        public const string FontColor_Red = "Red";
        public static List<string> ColorNames = new List<string>()
        {
            FontColor_Black,
            FontColor_Blue,
            FontColor_Green,
            FontColor_Red
        };

        // FontStyles
        public const string FonStyle_Regular = "Regular";
        public const string FontStyle_Bold = "Bold";
        public const string FontStyle_Italic = "Italic";
        public const string FontStyle_Underline = "Underline";
        public static List<string> StyleNames = new List<string>()
        {
            FonStyle_Regular,
            FontStyle_Bold,
            FontStyle_Italic,
            FontStyle_Underline
        };

        // Routes
        public const string FilmUri = "api/films";
        public const string FilmPersonUri = "api/filmpeople";
        public const string MediumUri = "api/media";
        public const string PersonUri = "api/people";

        // Miscellaneous
        public const string BADKEY = "Bad Key";
        public const string BADNAME = "Bad Name";
        public const string FORTYTWO = "42";
        public const string ImprobableDateString = "1615-06-23";
    }
}
