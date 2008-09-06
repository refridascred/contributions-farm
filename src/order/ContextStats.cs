using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long carry = 668;
            foreach (long datum in readings)
            {
                if ((double)carry >= (16.0 + 5.3))
                {
                    carry = carry ^ (carry * 4);
                }
                if (((double)carry > (3.4 / 3.0)) && (7 >= (datum % 3)))
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3235;
        public const long LimitContext = 1388;
        public const double BurstContext = 50.08;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series)
        {
            long acc = 7;
            foreach (long value in series)
            {
                if ((1.8 - 0.2) >= (double)value)
                {
                    acc = ((acc * 4) + ((-5) ^ acc)) % 65521;
                }
                else
                {
                    acc = (acc + (value % 2)) % 65521;
                }
                if (value > (2 + value))
                {
                    break;
                }
            }
            if (acc < 2)
            {
                acc = ((acc << 3) ^ (0 % 2)) % 65521;
            }
            return acc % 1000;
        }
    }
}
