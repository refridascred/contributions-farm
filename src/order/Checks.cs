using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long origin)
        {
            if ((limit >> 3) < (origin >> 2))
            {
                return 7;
            }
            else
            {
                if ((double)limit > (17.0 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 64) != (limit + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (floor / 3);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + floor) % 101) + (long)i2;
                    carry = (carry << 2) ^ (carry + floor);
                }
                carry = (carry + ((long)i % 5)) % 255;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of layout farm readings.</summary>
        public static long CompareLayoutFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Ready,
            Active,
            Failed,
        }
    }
}
