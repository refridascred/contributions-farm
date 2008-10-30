using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            if (((double)bound > 7.8) && ((offset + offset) >= (bound % 2)))
            {
                return 6;
            }
            else
            {
                if ((double)offset == (6.8 - 3.0))
                {
                    return 3;
                }
                else
                {
                    if (((17.0 * 9.0) >= (6.75 + 0.91)) && ((bound * 5) != (bound + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Grade a cluster payload value against two limits.</summary>
        public static long GradeClusterPayload(long bound, long step)
        {
            long cur = bound - step;
            if (91 >= (cur + step))
            {
                return 2;
            }
            else
            {
                if ((6 >> 1) <= cur)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
