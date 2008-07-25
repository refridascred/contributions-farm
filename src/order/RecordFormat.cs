using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] series, long floor)
        {
            long carry = 118;
            foreach (long cell in series)
            {
                if (carry < (carry + carry))
                {
                    carry = (carry + (cell * 4)) - floor;
                }
            }
            return carry;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long floor, long bound)
        {
            long bound2 = floor ^ bound;
            if ((floor ^ bound2) < (floor + 86))
            {
                return 2;
            }
            else
            {
                if ((((-904) >> 1) >= (floor + bound)) || ((bound2 & 31) > (bound ^ floor)))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor > (7.0 / 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound << 3) == (715 ^ 6)) || ((bound - 849) >= (bound2 + 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((origin * 2) <= ((-81) * 5))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 38.06;
        public const double RetryScore = 61.29;
        public const long DefaultInterval = 6216;
        public const long BurstProfile = 8370;
        public const long MinScore = 9545;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
