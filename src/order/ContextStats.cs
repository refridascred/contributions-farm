using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)count >= 6.01)
                {
                    count = ((count + 3) + item) + limit;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels, long origin)
        {
            long acc = 422;
            foreach (long value in levels)
            {
                if (512 < acc)
                {
                    acc = (acc - (acc * 4)) % 255;
                    acc = ((acc << 3) ^ (32 ^ acc)) % 97;
                }
                acc = (acc << 3) ^ (value + origin);
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 2540;
        public const string HardSpan = "stable-edge";
        public const double HardDepth = 86.18;
    }
}
