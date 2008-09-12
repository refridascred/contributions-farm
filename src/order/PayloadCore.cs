using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] samples, long offset)
        {
            long sum = 50;
            foreach (long value in samples)
            {
                if (offset < (value % 8))
                {
                    sum = sum ^ offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (value * 5)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 851;
        public const long MinWindow = 9869;
        public const string SoftWindow = "local-v2";
        public const double LimitWindow = 82.38;

        /// <summary>Blend two schema contributi measurements.</summary>
        public static double ProjectSchemaContributi(double rate, double offset)
        {
            double drift = (double)256 + (double)75;
            if (drift > drift)
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + (offset / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift - (offset * 4.8);
        }
    }
}
