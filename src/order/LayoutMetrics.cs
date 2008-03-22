using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Done,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 50.99;
        public const long RetryRatio = 1288;
        public const long DefaultDepth = 2588;
        public const string StepSpan = "cached-1";
        public const double DefaultRatio = 35.75;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
