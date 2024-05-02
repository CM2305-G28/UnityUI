using System.Collections.Generic;

namespace General_scripts
{
    public class Objective 
    {
        string task;
        bool complete;
        

        public Objective(string task, bool complete){
            this.task=task;
            this.complete=complete;
        }

        public void setComplete(bool value){
            this.complete = value;
        }

        public bool isComplete(){
            return this.complete;
        }

        public string getTask(){
            return this.task;
        }

        public void setTask(string text){
            this.task=text;
        }
    }
}
