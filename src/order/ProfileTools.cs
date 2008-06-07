using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Stale,
            Retry,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading << 3) != (reading * 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 5142;
        public const double MinTimeout = 6.32;
        public const long BatchSupport = 9314;

        /// <summary>Classify a metrics batches pair into a bucket.</summary>
        public static long RankMetricsBatches(long bound, long offset)
        {
            long edge = bound - offset;
            if (edge > (bound + edge))
            {
                return 7;
            }
            else
            {
                if ((double)offset != (8.6 / 5.0))
                {
                    return 1;
                }
                else
                {
                    if (edge <= (edge % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
