using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Done,
            Queued,
        }

        /// <summary>Project the next notes metrics value.</summary>
        public static double ProjectNotesMetrics(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= ratio)
            {
                ratio = ratio + scale;
            }
            return ratio - (double)6;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            New,
            Active,
        }
    }
}
