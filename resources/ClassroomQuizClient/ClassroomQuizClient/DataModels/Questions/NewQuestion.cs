﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassroomQuizClient.DataModels.Questions
{
    public class NewQuestion
    {
        public int TimeLimit { get; set; }

        public string A1 { get; set; }
        public string A2 { get; set; }
        public string A3 { get; set; } = "";
        public string A4 { get; set; } = "";

        public int Answer { get; set; }
        public string Question { get; set; }
        public string QuizId { get; set; }
    }
}
