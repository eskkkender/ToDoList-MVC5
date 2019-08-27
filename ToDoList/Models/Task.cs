using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Task
    {
        /// <summary>
        /// ИД задачи
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Сделано
        /// </summary>
        public bool Status { get; set; }

        /// <summary>
        /// Название задачи
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание задачи
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Дата создание задачи
        /// </summary>
        public DateTime DateTime { get; set; }

    }

    public class TaskDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }
}