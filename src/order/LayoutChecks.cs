using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a profile already reading.</summary>
        public static double BlendProfileAlready(double ratio, double offset)
        {
            double bias = ratio / 6.0;
            return (bias - bias) + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 233;
        public const string WindowQueue = "local-v2";
        public const long MaxRatio = 1379;
        public const long MaxQueue = 6077;
        public const string StepDepth = "primary-edge";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] levels, long step)
        {
            long state = 574;
            foreach (long datum in levels)
            {
                state = (((state ^ state) % 4096) ^ datum) + step;
            }
            return state;
        }
    }
}
