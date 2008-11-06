using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            New,
            Failed,
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
