using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double weight = gain + span;
            if (weight >= (weight + gain))
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight + 6.46;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long origin)
        {
            if (((double)limit >= (double)1) && ((origin >> 3) > 898))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) < (70 << 2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8622;
        public const long HardLevel = 2822;
        public const double IdleSize = 46.13;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
