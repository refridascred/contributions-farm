using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long seed)
        {
            long carry = 7;
            foreach (long sample in values)
            {
                carry = ((carry * 2) + carry) ^ sample;
            }
            if (carry < 636)
            {
                carry = ((carry << 3) ^ seed) % 101;
            }
            return carry % 97;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double offset)
        {
            double bias = (double)(-9) / 8.0;
            if (bias > (double)278)
            {
                bias = (bias - (double)(-3)) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (4.9 + offset)) + (double)(long)i;
            }
            return bias - (bias / 8.0);
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] values, long floor)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if (cell > (1 / 9))
                {
                    result = ((result ^ (cell + (long)values.Length)) % 255) - floor;
                }
            }
            if (result < (-587))
            {
                result = (result * 2) + (748 & 127);
            }
            return result;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
