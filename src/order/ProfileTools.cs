using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long floor, long offset)
        {
            long bound = floor - offset;
            if ((bound % 24) < 40)
            {
                return 0;
            }
            else
            {
                if ((double)offset > (4.9 - 7.54))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (!((seed + (long)i) >= ((long)i / 2)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state ^ (17 + state)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double bias = offset;
            if (bias < (offset / 8.0))
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (scale * 5.0)) + (double)(long)i;
            }
            return bias - (double)6;
        }
    }
}
