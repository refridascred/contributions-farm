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

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Failed,
            Draft,
            Synced,
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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long floor)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                carry = (((carry << 2) ^ floor) % 101) ^ reading;
            }
            return carry;
        }
    }
}
