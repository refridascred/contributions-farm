using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long bound)
        {
            long edge = target + bound;
            if ((bound + target) > edge)
            {
                return 6;
            }
            else
            {
                if ((double)edge == (4.3 * 16.0))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
