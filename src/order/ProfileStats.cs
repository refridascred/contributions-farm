using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool GuardQueuePayloadRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - reading) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm buffer series from a seed.</summary>
        public static long StepFarmBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((sum & 63) == ((long)i % 2))
                {
                    sum = (sum + ((long)i - bound)) % 1000;
                }
                sum = (sum << 2) ^ (sum % 64);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
