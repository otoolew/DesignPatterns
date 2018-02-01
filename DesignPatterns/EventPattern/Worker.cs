using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.EventPattern
{

    class Worker
    {
        // Better for Event Only
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }
        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            //if (del != null)
            //{
            //    del(this, new WorkPerformedEventArgs(hours, workType));
            //}
            (WorkPerformed as EventHandler<WorkPerformedEventArgs>)?.Invoke(this, new WorkPerformedEventArgs(hours, workType));

        }
        protected virtual void OnWorkCompleted()
        {
            //var del = WorkCompleted as EventHandler;
            //if (del != null)
            //{
            //    del(this, EventArgs.Empty);
            //}
            (WorkCompleted as EventHandler)?.Invoke(this, EventArgs.Empty);
        }
    }
}
