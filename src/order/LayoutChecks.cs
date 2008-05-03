using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count support profile pairs that satisfy a relation.</summary>
        public static long PairSupportProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1216;
        public const string LimitContributi = "cached";
        public const string MaxScore = "legacy";
        public const long WindowContributi = 5900;
        public const double BurstScore = 73.48;

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double ScaleBatchChecks(double weight, double bias)
        {
            double drift = (double)13 + 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (weight / 2.0);
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor - (step << 1)) % 4096) ^ (long)i2;
                }
                anchor = anchor + (step / 3);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double gain, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (bias * 3.35)) - (double)(long)i;
            }
            return bias + (floor + gain);
        }
    }
}
