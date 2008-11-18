using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8834;
        public const double IdleTimeout = 6.36;
        public const double StepDepth = 17.0;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
