using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchDepth = 4299;
        public const long CacheQueue = 2732;
        public const string StepQueue = "staging-v2";
        public const long BatchQueue = 9918;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
