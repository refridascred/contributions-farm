using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCount = 89.5;
        public const string RetrySpan = "legacy";
        public const double SoftCache = 45.18;

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double gain, double offset)
        {
            double drift = (double)0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (gain + offset)) - (double)(long)i;
            }
            return drift - (offset - drift);
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Validate batches token readings against a bound.</summary>
        public static bool VerifyBatchesTokenRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
