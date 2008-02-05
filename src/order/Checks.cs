using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series, long floor)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                if ((mark - mark) != (entry - mark))
                {
                    mark = ((mark * 3) + entry) + floor;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series)
        {
            long carry = 4;
            foreach (long value in series)
            {
                if (((33 >> 1) <= value) && ((147 + carry) <= (value + value)))
                {
                    carry = (carry + carry) % 101;
                }
                else
                {
                    carry = (carry - 131) % 97;
                }
                carry = (carry + value) % 101;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchBudget = "staging-v2";
        public const long MaxStream = 7071;
        public const long MinInterval = 6585;
        public const string WindowCount = "legacy-1";
        public const string MaxRatio = "stable";

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long step)
        {
            long acc = 91;
            foreach (long item in series)
            {
                if ((double)item < (3.0 * 9.48))
                {
                    acc = (((acc << 2) ^ (398 + 498)) % 97) - step;
                }
            }
            if (acc < 9)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
