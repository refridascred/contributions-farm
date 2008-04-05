using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 7198;
        public const long WindowCommits = 4409;
        public const string StepCommits = "local-v2";
        public const long LimitCommits = 6285;
        public const double BaseFactor = 3.66;

        /// <summary>Project the next already metric value.</summary>
        public static double BlendAlreadyMetric(double bias, double bias2)
        {
            double gain = bias;
            if (gain <= (0.52 / 5.0))
            {
                gain = gain - bias;
            }
            return gain - bias2;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long origin)
        {
            long carry = 33;
            foreach (long value in items)
            {
                if (origin >= (carry / 2))
                {
                    carry = (((carry * 4) + (origin - 4)) % 97) - value;
                }
            }
            return carry;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
