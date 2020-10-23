using System;

namespace PomodoroLib
{

    //default: 4 sessions of 25 min, 20 mins of rest
    // 25 | 5 | 25 | 5 | 25 | 5 | 25 | 20
    // w    r   w    r   w    r   w    r
    public class PomodoroScheduler
    {
        private int WorkLeft;
        public int DurationOfPomodoro { get; set; } = 25;
        public int RestDuration = 5;
        public int LastRestDuration = 20;
        public int MaxPomodorosInRound = 4;
        public int InARow { get; set; } = 0;
        public int NextDuration { get; set; }

        public int PomodorosToday = 0;
        public enum State
        {
            WORKING, 
            REST
        }

        private PomodoroStatistics Stats;
        public State CurrentState { get; set; } = State.REST;
        public PomodoroScheduler(PomodoroStatistics stat)
        {
            Stats = stat;
            WorkLeft = MaxPomodorosInRound;
            CurrentState = State.REST;
        }

        
        public void NextActivity()
        {
            if(LastActivityWasWorking())
            {
                // THIS MEANS NOW IS LAST REST STAGE
                if (WorkIsDone())
                {
                    StartLastRestStage();
                }
                else // THIS MEANS NOW IS COMMON REST STAGE
                {
                    Rest();
                }
                CurrentState = State.REST;
                InARow++;
            }
            else // Last activity was resting so now we will work
            {
                CurrentState = State.WORKING;
                NextDuration = DurationOfPomodoro;
            }
            Stats.AddNumberOfPomodorosInARowToday(PomodorosToday);
            Stats.AddNumberOfPomodorosInARowToday(InARow);
        }

        private void Rest()
        {
            WorkLeft--;
            NextDuration = RestDuration;
        }

        private void StartLastRestStage()
        {
            PomodorosToday++;
            NextDuration = LastRestDuration;
        }

        public void ResetSchedule()
        {
            WorkLeft = MaxPomodorosInRound;
            InARow = 0;
            CurrentState = State.REST;
            NextDuration = DurationOfPomodoro;
        }

        public bool LastActivityWasWorking()
        {
            return CurrentState == State.WORKING;
        }
        public bool WorkIsDone()
        {
            return WorkLeft == 0;
        }
    }
}
