using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double RetryTimeout = 16.3;
        public const long RetryCount = 6310;
        public const long RetryContext = 6616;
        public const double WindowContext = 76.16;

        /// <summary>Fold a list of checks metrics readings.</summary>
        public static long ScoreChecksMetrics(long[] samples)
        {
            long mark = 70;
            foreach (long datum in samples)
            {
                mark = ((mark << 3) ^ (datum << 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] series)
        {
            long acc = 181;
            foreach (long item in series)
            {
                acc = (acc ^ (3 - item)) % 65521;
            }
            if (acc < 16)
            {
                acc = ((acc << 2) ^ ((long)series.Length ^ acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
