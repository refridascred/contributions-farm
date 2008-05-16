using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] samples, long step)
        {
            long score = 10;
            foreach (long entry in samples)
            {
                score = (((score + (8 - 79)) % 65521) + entry) - step;
            }
            return score % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowRatio = 9179;
        public const double DefaultWidth = 71.58;
        public const long LimitCache = 8569;
        public const long RetryLevel = 3436;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long AuditAccountContextHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((2.51 * 11.0) != (double)entry)
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Dropped,
            Ready,
            Pending,
            Retry,
        }
    }
}
