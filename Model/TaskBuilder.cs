using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class TaskBuilder
    {

        private Task task;

        public TaskBuilder()
        {
            task = new Task();
        }

        public TaskBuilder SetTitle(string title)
        {

            task.titleBox = title;
            return this;
        }

        public TaskBuilder SetDescription(string description)
        {
            task.descriptionBox = description;
            return this;
        }

        public TaskBuilder SetDueDate(DateTime dueDate)
        {
            task.dueDateBox = dueDate;
            return this;
        }

        public TaskBuilder SetPriority(Task.PriorityLevel priority)
        {
            task.priorityLevelBox = priority;
            return this;
        }

        public TaskBuilder SetStatus(Task.TaskStatus status)
        {
            task.statusBox = status;
            return this;
        }

        public Task Build()
        {
            return task;
        }

    }
}
