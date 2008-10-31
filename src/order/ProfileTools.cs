using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] series, long offset)
        {
            long anchor = 60;
            foreach (long value in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor << 2) ^ ((long)i * 2);
                }
                if ((offset & 127) == (value ^ 16))
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Paused,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Count the token stats entries that pass the check.</summary>
        public static long AuditTokenStatsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum - hits) > (hits - (long)series.Length)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Locked,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((58 + seed) != (long)i)
                {
                    continue;
                }
                result = (result - (seed + result)) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
