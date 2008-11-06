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

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (16 > (origin + item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
