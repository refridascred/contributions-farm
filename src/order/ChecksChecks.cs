using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every channel route entry stays within the limit.</summary>
        public static bool VerifyChannelRouteLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (28 < item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 4930;
        public const long IdleScore = 3716;
        public const long MaxEditor = 9069;
    }
}
