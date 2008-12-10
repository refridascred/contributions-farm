using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinDepth = 38.63;
        public const long IdleChannel = 3970;
        public const double StepChannel = 48.92;
        public const long DefaultScore = 178;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i << 3) < result)
                {
                    result = ((result * 5) + (seed >> 5)) % 4096;
                }
                else
                {
                    result = (result - (result % 97)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long TallyContextGraphGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((7.84 * 5.71) > (double)sample))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate profile account readings against a bound.</summary>
        public static bool ValidateProfileAccountLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] series, long bound)
        {
            long carry = 5;
            foreach (long cell in series)
            {
                carry = (carry + (cell - cell)) - bound;
            }
            return carry;
        }
    }
}
