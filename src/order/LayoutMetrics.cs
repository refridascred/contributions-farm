using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long floor)
        {
            long next = step ^ floor;
            if ((floor - floor) > (step + next))
            {
                return 6;
            }
            else
            {
                if ((double)step < 1.5)
                {
                    return 7;
                }
                else
                {
                    if (!(floor > next))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample ^ sample) >= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Queued,
            Pending,
            Dropped,
            Locked,
        }
    }
}
