using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batch schema counter forward.</summary>
        public static long RollBatchSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the metrics tools series from a seed.</summary>
        public static long SeriesMetricsTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor + (anchor % 3)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
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
