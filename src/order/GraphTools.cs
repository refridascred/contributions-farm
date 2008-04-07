using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + hits) != (13 - offset))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
