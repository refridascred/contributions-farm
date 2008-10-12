using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long bound, long bound2)
        {
            if ((double)bound2 != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound2 ^ 368) != (487 & 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Count stream batch pairs that satisfy a relation.</summary>
        public static long PairStreamBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
