using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double span)
        {
            double bias = span;
            if (bias < weight)
            {
                bias = bias - (weight * 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)6) + (double)(long)i;
            }
            return bias + (span - span);
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] values, long bound)
        {
            long acc = 359;
            foreach (long datum in values)
            {
                if ((12.0 * 13.0) < (double)1)
                {
                    acc = ((acc + (datum + 533)) % 255) - bound;
                }
            }
            return acc;
        }
    }
}
