using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 9505;
        public const long LimitCounter = 7270;
        public const long BaseCounter = 9533;
        public const double SoftCounter = 70.59;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Queued,
            Closed,
            Dropped,
            Paused,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every tools payload entry stays within the limit.</summary>
        public static bool GuardToolsPayloadRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
