using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long step)
        {
            long cur = floor - step;
            if ((3.5 + 13.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((step + cur) > floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinTimeout = "open-v2";
        public const long BatchSize = 6811;
        public const long MaxCache = 5501;
        public const long IdleInterval = 9194;
        public const long LimitCache = 2001;

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two editor metric measurements.</summary>
        public static double ProjectEditorMetric(double rate, double floor)
        {
            double weight = (rate + floor) + floor;
            if (weight < (floor * 9.83))
            {
                weight = weight + (double)(-6);
            }
            return weight + rate;
        }
    }
}
