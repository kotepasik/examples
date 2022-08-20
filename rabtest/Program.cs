// // Антипаттерн (так делать нельзя) не понятно откуда бкруться 30 и 4

void DrawText(string text, int left, int top)
{
     Console.SetCursorPosition(left, top);
     Console.WriteLine(text);
}

// DrawText("Intensive C# Demo text", 30, 4);


// Правильно будет вот так

string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

// DrawText(caption, screenWidthPosition, screenHeightPosition); // можно так обращаться к методу, но не стоит
// Ниже более правильный формат записи вызова метода с несколькоми аргументами

DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
);


