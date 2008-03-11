using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long limit2)
        {
            long edge = limit + limit2;
            if ((0 >= (333 ^ edge)) && ((double)limit <= (6.72 + 3.8)))
            {
                return 0;
            }
            else
            {
                if (((limit ^ limit) <= 912) && ((double)limit < 0.9))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 - limit2) == (edge + limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
