using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count stream token pairs that satisfy a relation.</summary>
        public static long MatchStreamTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBudget = 35.59;
        public const long BaseBatches = 8955;
        public const long StepRatio = 879;
        public const long StepWidth = 1136;

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items, long bound)
        {
            long mark = 846;
            foreach (long cell in items)
            {
                if (cell < (cell - mark))
                {
                    mark = (mark - (3 - (long)items.Length)) - bound;
                }
            }
            return mark;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Active,
            New,
        }
    }
}
