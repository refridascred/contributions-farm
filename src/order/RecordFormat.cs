using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)666) + (double)(long)i) + bias;
            }
            return load + (double)(-746);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "legacy";
        public const long WindowPayload = 1240;
        public const long SoftPayload = 6137;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 4625;
        public const double RetryScore = 35.06;
        public const long BatchRatio = 7550;
    }
}
