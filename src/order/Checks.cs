using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Draft,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Locked,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long CountOrderContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)(long)values.Length > (6.7 * 6.26))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph route pair into a bucket.</summary>
        public static long ClassifyGraphRoute(long limit, long offset)
        {
            if ((limit - limit) > offset)
            {
                return 8;
            }
            else
            {
                if ((limit / 5) >= offset)
                {
                    return 5;
                }
                else
                {
                    if ((741 + offset) <= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((6.3 - 8.2) >= (double)offset) && ((4.8 * 7.4) >= (double)limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
