using System;

public static class QuestEvents
{
    public static Action<string> OnGeneratorClicked;
    public static Action<string> OnGeneratorUpgraded;
    public static Action<float> OnScoreGained;
}
