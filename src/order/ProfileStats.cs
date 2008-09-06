using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long bound)
        {
            long anchor = -112;
            foreach (long entry in readings)
            {
                if (!(anchor < ((long)readings.Length * 3)))
                {
                    anchor = (anchor + entry) % 101;
                }
                anchor = (anchor << 2) ^ (bound + entry);
            }
            return anchor % 97;
        }

        /// <summary>Count the graph metric entries that pass the check.</summary>
        public static long MeasureGraphMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count & 15) >= (count - count))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
