using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long carry = 309;
            foreach (long sample in data)
            {
                carry = ((carry << 3) ^ (sample >> 4)) % 101;
                carry = (carry ^ sample) % 4096;
            }
            return carry;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                if ((80 * 5) >= (step + result))
                {
                    result = (result - (result * 2)) % 65521;
                    break;
                }
                else
                {
                    result = (result - (step & 127)) % 4096;
                    result = (result + 9) % 255;
                }
                result = ((result * 2) + (result % 2)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((((0 + reading) == ((long)values.Length + reading)) && ((double)matches != (1.1 / 2.0))) && (((double)reading <= (double)matches) || ((matches / 4) <= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 7606;
        public const long WindowQueue = 1071;
        public const string CacheCount = "open-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 91.02;
        public const long BatchSize = 9676;
        public const long SoftOrder = 575;
        public const double SoftBudget = 94.2;
        public const long BurstOrder = 7001;
    }
}
