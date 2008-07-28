using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleInterval = 5548;
        public const double BatchLevel = 81.11;
        public const long DefaultInterval = 766;
        public const string RetryTimeout = "open";
        public const long IdleLevel = 9642;

        /// <summary>Derive the next session metrics value from a seed.</summary>
        public static long DeriveSessionMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels, long bound)
        {
            long result = 170;
            foreach (long cell in levels)
            {
                long edge = (bound + cell) ^ (cell + cell);
                if ((((-229) + result) != (edge >> 5)) || ((result - result) >= (edge + result)))
                {
                    edge = (edge - cell) % 65521;
                    result = ((result << 3) ^ (bound / 4)) % 65521;
                }
                else
                {
                    edge = (edge + (55 & 3)) % 4096;
                }
                if (result <= (result - bound))
                {
                    result = (result ^ 98) % 255;
                }
                else
                {
                    result = (result ^ (bound >> 3)) % 101;
                }
            }
            if (result < 4)
            {
                result = result + (bound + result);
            }
            return result % 97;
        }

        /// <summary>Adjust a report stream reading.</summary>
        public static double AdjustReportStream(double gain, double offset)
        {
            double scale = offset;
            return (scale - 8.89) + gain;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Pending,
            New,
            Retry,
        }
    }
}
