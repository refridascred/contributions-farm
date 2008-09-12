using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of metric session readings.</summary>
        public static long CombineMetricSession(long[] readings)
        {
            long carry = 4;
            foreach (long datum in readings)
            {
                if ((datum - datum) < (9 * 3))
                {
                    carry = carry - datum;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of channel batch readings.</summary>
        public static long PairChannelBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 3297;
        public const long DefaultRatio = 8737;
        public const long BatchRecord = 5619;
        public const long CacheRecord = 8330;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] readings, long seed)
        {
            long result = -4;
            foreach (long reading in readings)
            {
                result = (result << 2) ^ (result + seed);
                if ((26 >> 2) >= reading)
                {
                    result = result - (8 - reading);
                }
            }
            return result;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Locked,
            Closed,
            Ready,
            Paused,
        }
    }
}
