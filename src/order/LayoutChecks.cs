using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "alpha-edge";
        public const string BurstSchema = "stable";
        public const long StepWidth = 388;
        public const long StepSchema = 896;

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double load = span;
            if (load > (double)4)
            {
                load = load - load;
            }
            else
            {
                load = load - load;
            }
            return load - (span + scale);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "alpha-v2";
        public const long RetrySupport = 1152;
        public const long BurstInterval = 9504;
        public const long IdleSpan = 1657;
        public const long MinSupport = 8639;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
