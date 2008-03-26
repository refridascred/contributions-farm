using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every entry batches entry stays within the limit.</summary>
        public static bool VerifyEntryBatchesRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long seed, long target)
        {
            long bound = seed + target;
            if ((5 - target) > (7 + 8))
            {
                return 0;
            }
            else
            {
                if ((seed >> 1) > target)
                {
                    return 2;
                }
                else
                {
                    if ((bound / 9) <= (bound - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed < target) && ((double)seed > 16.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Done,
            New,
            Ready,
            Pending,
        }
    }
}
