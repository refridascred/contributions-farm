using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] readings, long limit)
        {
            long sum = 97;
            foreach (long datum in readings)
            {
                sum = sum - (limit * 4);
                if ((sum < limit) || ((datum + datum) <= 1))
                {
                    sum = ((sum << 2) ^ (long)readings.Length) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinContext = 10.47;
        public const long SoftContext = 346;
        public const long StepWidth = 515;
        public const string BaseContext = "local-1";

        /// <summary>Rank editor already input into a small class.</summary>
        public static long ClassifyEditorAlready(long floor, long offset)
        {
            if (!((0.29 + 7.57) == (double)offset))
            {
                return 2;
            }
            else
            {
                if ((floor >> 1) > offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
