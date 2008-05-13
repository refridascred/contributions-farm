using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long origin, long step)
        {
            if (origin <= step)
            {
                return 7;
            }
            else
            {
                if (!((6.75 / 5.0) >= (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (15 < (origin + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin <= (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Dropped,
            Synced,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Active,
            Dropped,
            Pending,
            Locked,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
