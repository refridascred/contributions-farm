using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Check that every payload githubfarm entry stays within the limit.</summary>
        public static bool ValidatePayloadGithubfarmRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "cached-v2";
        public const long RetryPayload = 4357;
        public const long SoftSize = 222;
        public const long DefaultPayload = 7691;
        public const long BatchPayload = 9612;
    }
}
