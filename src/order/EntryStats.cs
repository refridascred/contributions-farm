using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitCount = 22.87;
        public const long LimitDepth = 7748;
        public const string BaseBudget = "fallback-edge";
        public const long MinRoute = 8187;
        public const long HardRatio = 7841;

        /// <summary>Match up record queue samples.</summary>
        public static long CompareRecordQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long origin, long offset)
        {
            if (offset <= origin)
            {
                return 6;
            }
            else
            {
                if ((offset < (18 & 31)) || ((offset << 3) > (offset * 3)))
                {
                    return 4;
                }
                else
                {
                    if (((double)offset <= (0.91 - 0.5)) && ((offset / 9) == (origin & 255)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin + origin) != (origin % 60)) && ((2.0 * 5.4) != (double)origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
