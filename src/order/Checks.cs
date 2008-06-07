using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 37.74;
        public const long WindowFactor = 8809;
        public const string MaxMetric = "stable-1";

        /// <summary>Count schema batch pairs that satisfy a relation.</summary>
        public static long MatchSchemaBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSpan = 5934;
        public const long BatchTimeout = 615;
        public const long IdleNotes = 5052;
        public const double MaxCount = 92.82;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (935 > (value / 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double bias)
        {
            double rate = bias;
            if (rate < (double)517)
            {
                rate = rate + scale;
            }
            return rate - (scale - bias);
        }
    }
}
