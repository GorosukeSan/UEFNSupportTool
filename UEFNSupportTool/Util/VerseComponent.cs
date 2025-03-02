using System.Text.RegularExpressions;

namespace UEFNSupportTool.Util;

public class VerseComponent
{
    private static readonly string BeginActor = "Begin Actor";
    private static readonly string EndActor = "End Actor";
    private static readonly string VerseTagMarkupComponent =
        "         InstanceComponents(0)=\"/Script/VerseGameplayTags.VerseTagMarkupComponent'VerseTagMarkup'\"";

    private static readonly string VerseTagMarkupComponentObject = 
        @$"
         Begin Object Class=/Script/VerseGameplayTags.VerseTagMarkupComponent Name=""VerseTagMarkup"" ExportPath=""/Script/VerseGameplayTags.VerseTagMarkupComponent''""
                     CreationMethod=Instance
         End Object";
    
    public static string PutVerseComponent(string text)
    {
        if (!(text.Contains(BeginActor) && text.Contains(EndActor)))
        {
            return text;
        }
        try
        {
            int BeginActorIndex = text.IndexOf(BeginActor);
            int EndActorIndex = text.LastIndexOf(EndActor) + EndActor.Length;
            string ActorText = text.Substring(BeginActorIndex, EndActorIndex - BeginActorIndex);
            string PreActorText = text.Substring(0, BeginActorIndex);
            string PostActorText = text.Substring(EndActorIndex);
            var DividedActorText = DivideActor(ActorText);

            var convertedTemp = new List<string>();
            foreach (string textElement in DividedActorText)
            {
                convertedTemp.Add(CheckVerseComponent(textElement));
            }

            string convertedText = string.Join("\n", convertedTemp);

            return $"{PreActorText}{convertedText}{PostActorText}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
        
    }

    private static List<string> DivideActor(string text)
    {
        var result = new List<string>();
        var currentText = text;

        while (currentText.Contains(BeginActor) && currentText.Contains(EndActor))
        {
            int BeginActorIndex = currentText.IndexOf(BeginActor);
            int EndActorIndex = currentText.IndexOf(EndActor) + EndActor.Length;
            string ActorText = currentText.Substring(BeginActorIndex, EndActorIndex - BeginActorIndex);
            result.Add(ActorText);
            currentText = currentText.Remove(BeginActorIndex, EndActorIndex - BeginActorIndex);
        }

        return result;
    }

    private static string CheckVerseComponent(string text)
    {
        if (text.Contains(VerseTagMarkupComponent))
        {
            return text;
        }
        else
        {
            var checktext = "ActorLabel=\".+\"";
            var regex = Regex.Match(text, checktext);
            string actorLabel = regex.Value;
            string replaced = text.Replace(actorLabel, $"{actorLabel}\n{VerseTagMarkupComponent}");
            string inserted = replaced.Insert(replaced.IndexOf("End Object") + "End Object".Length, $"\n{VerseTagMarkupComponentObject}");
            
            return inserted;
        }
    }
}