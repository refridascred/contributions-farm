using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 110;
        public const double DefaultSpan = 88.31;
        public const string WindowSupport = "primary-v2";
        public const long SoftSupport = 3573;
        public const double HardWidth = 4.8;

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)2)
            {
                bias2 = (bias2 - 1.4) + scale;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias - bias2)) + (double)(long)i;
            }
            return bias2 - 7.2;
        }

        /// <summary>Count cluster session pairs that satisfy a relation.</summary>
        public static long CompareClusterSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long limit)
        {
            long anchor = 303;
            foreach (long value in levels)
            {
                if (!(6.72 < (double)value))
                {
                    anchor = (anchor ^ (anchor - anchor)) - limit;
                }
                else
                {
                    anchor = anchor ^ (value >> 3);
                }
                if ((9.8 - 5.09) > (double)anchor)
                {
                    anchor = (anchor - (value - value)) % 4096;
                }
                else
                {
                    anchor = (anchor - (40 + 831)) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long sum = 689;
            foreach (long cell in items)
            {
                sum = ((sum << 3) ^ (limit << 2)) - cell;
            }
            if (sum < 300)
            {
                sum = sum + (limit >> 4);
            }
            return sum % 65521;
        }
    }
}
