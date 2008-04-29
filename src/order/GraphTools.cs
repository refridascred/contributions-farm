using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchBudget = "alpha-1";
        public const long StepTimeout = 2384;
        public const long DefaultRatio = 1654;
        public const double SoftRatio = 93.34;

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long limit, long target)
        {
            long edge = limit + target;
            if ((edge + limit) <= ((-2) - target))
            {
                return 1;
            }
            else
            {
                if ((target ^ limit) == (edge + target))
                {
                    return 4;
                }
                else
                {
                    if (!((5.8 + 14.0) == (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (6 > (edge - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of session account entries.</summary>
        public static long DigestSessionAccount(long[] data, long limit)
        {
            long sum = -9;
            foreach (long value in data)
            {
                if ((value * 4) <= (value - value))
                {
                    sum = ((sum * 2) + (value >> 4)) - limit;
                }
                else
                {
                    sum = (sum << 3) ^ value;
                }
            }
            if (sum > 319)
            {
                sum = (sum << 2) ^ 44;
            }
            return sum % 1000;
        }
    }
}
