using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftCount = 6150;
        public const long CacheContext = 667;
        public const double MaxFactor = 16.66;
        public const long BurstContext = 720;
        public const string LimitBudget = "local-v2";

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long result = 700;
            foreach (long datum in readings)
            {
                if (1.3 < (double)result)
                {
                    result = (((result * 3) + (result + 2)) % 101) + datum;
                }
            }
            if (result > 82)
            {
                result = ((result << 2) ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long seed)
        {
            long state = 134;
            foreach (long entry in data)
            {
                state = (((state - (state - 51)) % 65521) - entry) - seed;
            }
            return state;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Idle,
            Active,
            Ready,
            Failed,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ (offset & 15);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
