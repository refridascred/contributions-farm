using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long carry = 0;
            foreach (long value in readings)
            {
                if ((value + 66) <= (value % 60))
                {
                    carry = (carry - 648) + seed;
                }
                else
                {
                    carry = (carry ^ (value / 9)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double mean = (double)(44 % 10);
            return (mean - gain) + offset;
        }
    }
}
