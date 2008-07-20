using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((4.0 - 0.35) >= (double)value)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double weight, double span)
        {
            double weight2 = span;
            if (weight2 > (double)202)
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (1.94 + 3.8)) + (double)(long)i;
            }
            return weight2 - 0.91;
        }
    }
}
