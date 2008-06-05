using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit tools entry readings against a rule.</summary>
        public static long AuditToolsEntryOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((floor + floor) < matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload account value from a seed.</summary>
        public static long DerivePayloadAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total ^ origin) % 65521) + (long)i2;
                }
                if ((double)total == (14.0 - 16.0))
                {
                    total = (total ^ total) % 97;
                    continue;
                }
                else
                {
                    total = ((total * 4) + origin) % 255;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((value ^ seen) == (bound + bound)) || ((seen ^ value) > value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 9894;
        public const long RetryLevel = 3990;
        public const long BurstReport = 4422;
    }
}
