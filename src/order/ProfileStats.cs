using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine graph tools values into a single score.</summary>
        public static long WeighGraphTools(long[] values, long seed)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if ((carry + carry) <= entry)
                {
                    carry = carry - seed;
                }
            }
            if (carry > 3)
            {
                carry = (carry + (carry / 4)) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((2 > matches) || ((29 ^ matches) != (floor - matches)))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + (long)values.Length) < reading)
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
