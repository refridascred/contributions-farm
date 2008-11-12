using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double floor)
        {
            double bias = (double)480 * 9.55;
            if (bias <= (double)35)
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (7.7 - floor);
        }
    }
}
