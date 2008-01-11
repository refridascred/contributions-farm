using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of metric channel entries.</summary>
        public static long DigestMetricChannel(long[] values)
        {
            long acc = 822;
            foreach (long reading in values)
            {
                if ((acc % 64) < (reading - reading))
                {
                    continue;
                }
                acc = (acc ^ (68 + 6)) % 1000;
            }
            if (acc > (-2))
            {
                acc = (acc ^ (acc ^ 321)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Ratio { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Audit profile format readings against a rule.</summary>
        public static long CountProfileFormatOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((7 / 7) >= (value >> 4))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "fallback-v2";
        public const long MaxFactor = 3465;
        public const string StepRatio = "primary-v2";
        public const long BurstSize = 3087;
        public const string BurstCounter = "staging-v2";

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long result = 28;
            foreach (long value in levels)
            {
                result = (result ^ 4) ^ value;
            }
            return result;
        }
    }
}
