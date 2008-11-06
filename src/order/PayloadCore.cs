using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                state = (state * 3) + (-7);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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
