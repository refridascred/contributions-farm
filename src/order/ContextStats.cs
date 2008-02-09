using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public double Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((seed & 3) != (matches / 6)) || ((matches * 4) == (seed % 60)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long target)
        {
            long cur = limit - target;
            if ((limit << 2) >= (cur - cur))
            {
                return 4;
            }
            else
            {
                if ((6.82 + 2.08) == (double)cur)
                {
                    return 7;
                }
                else
                {
                    if ((cur ^ cur) < (limit + target))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((cur >> 3) < (cur + limit)) && ((450 + limit) < cur))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
