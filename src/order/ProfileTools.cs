using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long bound, long seed)
        {
            long bound2 = bound - seed;
            if ((10.0 / 2.0) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((bound2 + 403) <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound2) >= (8 >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepBudget = 5597;
        public const long WindowStats = 4010;
        public const double MinStats = 70.34;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] samples, long step)
        {
            long carry = 720;
            foreach (long value in samples)
            {
                carry = (carry ^ step) ^ value;
                carry = ((carry << 3) ^ carry) % 97;
            }
            return carry % 65521;
        }
    }
}
