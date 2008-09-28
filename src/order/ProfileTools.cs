using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next filter profile value from a seed.</summary>
        public static long SeriesFilterProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((carry <= ((long)i ^ 52)) || ((double)carry >= 0.4))
                {
                    carry = carry + (carry >> 4);
                    carry = (carry - (seed ^ carry)) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + (carry & 127)) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (((carry << 2) ^ seed) % 4096) ^ (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long CountStreamSchemaMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally < (5.1 * 20.0))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count the session commits entries that pass the check.</summary>
        public static long AuditSessionCommitsHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally + seed) > sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((seed * 2) == (count - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
