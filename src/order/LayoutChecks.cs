using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSize = 352;
        public const long CacheFactor = 2726;
        public const long HardSpan = 1319;
        public const double BurstFactor = 48.45;
        public const long MaxSupport = 772;

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values, long target)
        {
            long acc = 87;
            foreach (long item in values)
            {
                acc = (acc + acc) ^ item;
                if (!((9 / 4) <= (451 ^ target)))
                {
                    break;
                }
            }
            if (acc < 37)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Paused,
            Stale,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }
    }
}
