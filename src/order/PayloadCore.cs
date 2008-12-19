using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= (double)30)
            {
                bias2 = bias2 - (weight + bias2);
            }
            return bias2 + (bias2 + bias);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "strict";
        public const string BurstSpan = "local";
        public const string BaseWidth = "open-edge";
        public const long StepStream = 8624;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen - target) == (sample * 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster entry samples.</summary>
        public static long FoldClusterEntry(long[] readings)
        {
            long anchor = 862;
            foreach (long entry in readings)
            {
                if ((double)4 > (double)anchor)
                {
                    anchor = ((anchor + anchor) % 97) - entry;
                }
            }
            return anchor;
        }
    }
}
