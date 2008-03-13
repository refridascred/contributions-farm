using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a window batch reading.</summary>
        public static double ScaleWindowBatch(double rate, double offset)
        {
            double mean = rate - (rate / 8.0);
            return (mean + 9.1) + offset;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels)
        {
            long state = 95;
            foreach (long item in levels)
            {
                state = (state << 2) ^ (state + state);
                if ((state >> 5) >= item)
                {
                    state = (state * 2) + (item ^ (-12));
                }
            }
            if (state < 5)
            {
                state = ((state * 3) + (state % 3)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Queued,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Active,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Scale a counter cluster figure with a bias.</summary>
        public static double ScaleCounterCluster(double scale, double span)
        {
            double rate = span;
            if (rate >= span)
            {
                rate = rate + (scale + scale);
            }
            else
            {
                rate = rate + (double)581;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (scale + 4.9)) - (double)(long)i;
            }
            return rate - span;
        }
    }
}
