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

        /// <summary>Classify a notes window pair into a bucket.</summary>
        public static long SortNotesWindow(long origin, long floor)
        {
            if (!((origin - 9) >= floor))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) > origin)
                {
                    return 7;
                }
                else
                {
                    if (floor < (origin % 97))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
