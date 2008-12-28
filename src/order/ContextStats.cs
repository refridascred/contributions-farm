using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(matches >= 31))
                {
                    matches = ((matches + 3) + item) - target;
                }
            }
            return matches;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double bias, double offset)
        {
            double drift = 8.54 + (double)843;
            return (drift + (drift + offset)) + bias;
        }
    }
}
