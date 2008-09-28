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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
