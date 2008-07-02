using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long PairBufferContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "cached-edge";
        public const long SoftRatio = 2963;
        public const string SoftWindow = "latest-edge";
        public const long IdleWindow = 376;

        /// <summary>Match up counter session samples.</summary>
        public static long MatchCounterSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (target / 6)) % 97;
                if ((target ^ carry) < carry)
                {
                    continue;
                }
                else
                {
                    carry = ((carry << 3) ^ (target % 97)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the metric format entries that pass the check.</summary>
        public static long CountMetricFormatHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((20.0 / 4.0) == (double)tally) || ((tally & 1) < (cell * 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
