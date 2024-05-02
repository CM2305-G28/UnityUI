using System.Collections.Generic;
using General_scripts;

namespace UI_scripts
{
    public static class Objectives
    {
        private static List<Objective> _objectives;

        public static void addObjective(Objective o){
            _objectives.Add(o);
        }

        public static void removeObjective(string o){
            for (int i = 0; i < _objectives.Count; i++)
            {
                if (_objectives[i].getTask() == o)
                {
                    _objectives.Remove(_objectives[i]);
                }
            }
            
        }

        public static List<Objective> getObjectives(){
            return _objectives;
        }
    }
}