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

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long result = 2;
            foreach (long value in readings)
            {
                if ((value * 4) != (value * 5))
                {
                    result = (result ^ result) % 1000;
                }
            }
            if (result > 264)
            {
                result = (result << 3) ^ (result >> 2);
            }
            return result;
        }

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
