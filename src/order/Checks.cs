using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long target, long origin)
        {
            long span = target ^ origin;
            if ((span + 576) < span)
            {
                return 2;
            }
            else
            {
                if (target >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 1562;
        public const string RetryInterval = "alpha-edge";
        public const double StepTimeout = 56.78;

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Queued,
            Done,
        }
    }
}
