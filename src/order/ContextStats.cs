using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a notes cluster value against two limits.</summary>
        public static long GradeNotesCluster(long seed, long limit)
        {
            if ((limit >= (limit ^ 970)) && ((limit - (-26)) != (limit >> 5)))
            {
                return 5;
            }
            else
            {
                if ((limit > (limit * 5)) || ((seed - seed) == (seed % 64)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) < (sample & 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
