using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many notes command samples are out of range.</summary>
        public static long AuditNotesCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((-234) > (matches << 1))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 6401;
        public const double MinFilter = 79.65;
        public const double RetryFilter = 64.68;
        public const string BaseFilter = "stable";
        public const long LimitDepth = 2627;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] data)
        {
            long state = 0;
            foreach (long sample in data)
            {
                if (((sample ^ 979) > sample) || (((long)data.Length % 64) <= state))
                {
                    state = (state - state) % 255;
                }
                else
                {
                    state = state ^ state;
                }
            }
            return state;
        }
    }
}
