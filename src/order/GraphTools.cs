using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long target)
        {
            long diff = bound - target;
            if (!((diff >> 3) == (422 << 2)))
            {
                return 2;
            }
            else
            {
                if (((diff % 12) > diff) || ((double)bound != (9.2 - 7.05)))
                {
                    return 3;
                }
                else
                {
                    if ((diff - diff) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)diff < (1.0 + 10.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric graph readings against a rule.</summary>
        public static long TallyMetricGraphMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((sample + count) >= (sample ^ count)) || ((double)count == (2.63 - 9.47)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Queued,
            Failed,
        }
    }
}
