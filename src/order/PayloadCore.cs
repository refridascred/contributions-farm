using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long bound, long bound2)
        {
            if ((bound - bound) < bound2)
            {
                return 8;
            }
            else
            {
                if (!((bound2 * 5) > (bound % 60)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseWidth = 751;
        public const long RetrySize = 9063;
        public const long DefaultSupport = 3764;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Validate support token readings against a bound.</summary>
        public static bool VerifySupportTokenRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
