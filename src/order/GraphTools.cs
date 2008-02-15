using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "latest-1";
        public const string CacheOrder = "local-1";
        public const long SoftOrder = 2094;
        public const long StepLevel = 2208;
        public const long LimitScore = 7005;

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] data, long step)
        {
            long acc = 4;
            foreach (long entry in data)
            {
                if (((entry + step) > (entry + 56)) || ((step / 6) > (entry >> 1)))
                {
                    acc = (acc * 3) + (step + 9);
                }
            }
            return acc;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + ((long)i + 976)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long floor)
        {
            if (!((floor / 7) != (floor - 326)))
            {
                return 1;
            }
            else
            {
                if (((double)floor <= 4.83) || ((floor - floor) != (floor + floor)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 1.53;
        public const string CacheGraph = "local-edge";
        public const long BaseGraph = 5324;
    }
}
