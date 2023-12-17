using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestSystem
{
    public string questname;
    public string questdescription;
    public string reward;
    public Objective objective;
    public short questcatrgory;

    [System.Serializable]
    public class Objective
    {
        public enum Type {drink,talk}
        public int objectiveID;
        public int amount;
        [System.NonSerialized]
        public int currentamount;
        public Type type;

        public bool CheckObjectiveCompleted(int id)
        {
            if (id == objectiveID)
            {
                currentamount++;
            }
            return currentamount >= amount;
        }
        public bool ForceAddObjective(int amount)
        {
            currentamount += amount;
            return currentamount >= amount;
        }
    }
}
