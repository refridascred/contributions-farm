using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = ((score << 3) ^ (score % 16)) % 4096;
                if (!(15 < (3 + seed)))
                {
                    break;
                }
                else
                {
                    score = ((score * 2) + ((long)i - seed)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
