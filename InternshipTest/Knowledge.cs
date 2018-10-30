using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipTest
{
    public class Knowledge
    {
        public KnowledgeLevel KnowledgeLevel { get; protected set; }

        public Knowledge(int level)
        {
            if (level > 4 || level < 0)
                throw new ArgumentException("Knowledge level should be >= 0 and <= 4");
            KnowledgeLevel = (KnowledgeLevel)level;
        }

    }

    public enum KnowledgeLevel
    {
        Low,
        BelowAverage,
        Average,
        AboveAverage,
        High
    }
}
