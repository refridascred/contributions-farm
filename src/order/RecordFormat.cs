using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two metric checks measurements.</summary>
        public static double ScaleMetricChecks(double weight, double bias)
        {
            double rate = (6.24 - bias) - (double)9;
            if (rate <= (weight * 9.0))
            {
                rate = rate - rate;
            }
            return rate - rate;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double bias2)
        {
            double bias3 = (double)(0 - (-509));
            if (bias3 < bias2)
            {
                bias3 = (bias3 - (bias2 - bias3)) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - (bias2 + bias2)) + (double)(long)i;
            }
            return bias3 + bias2;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
