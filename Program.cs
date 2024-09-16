//main

string input = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(input);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);
return 0;

//end main

static string GetEnjoymentLevel() {
    while (true) {
        System.Console.WriteLine("How fun do you want the game to be?\n(Boring, average, fun, or epic?)");
        string input = Console.ReadLine();
        if (input.ToLower() == "epic" || input.ToLower() == "fun" || input.ToLower() == "average" || input.ToLower() == "boring") {
            return input.ToLower();
        }
        else {
            System.Console.WriteLine("Please choose from the listed options.");
        }
    }
}

static string GetStadiumRecommendation(string enjoymentLevel) {
    switch (enjoymentLevel) {
        case "epic":
            return "Saban Field at Bryant-Denny Stadium";
        case "fun":
            return "Tiger Stadium";
        case "average":
            return "Jordan-Hare Stadium";
        case "boring":
            return "Neyland Stadium";
        default:
            return "error";
    }
}

static string GetGameRecommendation(string stadium) {
    switch (stadium) {
        case "Saban Field at Bryant-Denny Stadium":
            return "vs Auburn";
        case "Tiger Stadium":
            return "vs Alabama";
        case "Jordan-Hare Stadium":
            return "vs Kentucky";
        case "Neyland Stadium":
            return "vs Kent State";
        default:
            return "error";
    }
}


static void DisplayStadiumDetails(string stadium, string game) {
    Console.WriteLine($"Consider going to:\n\t{stadium}\n\t{game}");
}