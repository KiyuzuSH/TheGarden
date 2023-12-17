using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class QuestLog
{
    public static List<QuestSystem> questList;
    public static List<QuestSystem> completedQuest;

    public delegate void OnQuestChange(List<QuestSystem> activeQuests, List<QuestSystem> completedQuest);
    public static event OnQuestChange onQuestChange;

    public static void Initialize()
    {
        questList = new List<QuestSystem>();
        completedQuest=new List<QuestSystem>();
    }

    public static void AddQuest(QuestSystem quest)
    {
        questList.Add(quest);
        
    }

    public static void CompleteQuest(QuestSystem quest)
    {
        questList.Remove(quest);
        completedQuest.Add(quest);
    }

    public static QuestSystem getQuestNo(int index)
    {
        if (index < questList.Count)
            return questList[index];
        else
            return completedQuest[index - questList.Count];
    }
}
