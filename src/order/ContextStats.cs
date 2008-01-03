using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples, long step)
        {
            long result = -2;
            foreach (long sample in samples)
            {
                result = ((result + (step << 3)) % 1000) - sample;
            }
            return result % 1000;
        }

        /// <summary>Rank stream graph input into a small class.</summary>
        public static long GradeStreamGraph(long limit, long step)
        {
            long step2 = limit + step;
            if ((double)step >= (8.7 + 5.49))
            {
                return 4;
            }
            else
            {
                if ((double)15 <= (double)step2)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up format session samples.</summary>
        public static long MatchFormatSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
