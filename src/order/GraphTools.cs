using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank queue report input into a small class.</summary>
        public static long GradeQueueReport(long limit, long bound)
        {
            long diff = limit ^ bound;
            if (!(diff >= (diff % 3)))
            {
                return 1;
            }
            else
            {
                if ((double)diff > (7.2 + 2.2))
                {
                    return 6;
                }
                else
                {
                    if ((3 * 5) < (limit >> 5))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Queued,
            Active,
            Stale,
        }

        /// <summary>Classify a format metric pair into a bucket.</summary>
        public static long RankFormatMetric(long offset, long step)
        {
            long cur = offset ^ step;
            if ((offset - step) > (step + (-619)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (3.9 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 2) > (41 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (529 < (cur - offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
