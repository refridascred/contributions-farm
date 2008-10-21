using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((6.75 + 6.0) == (double)tally) && !((3.0 * 8.5) > (double)tally))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Rank editor record input into a small class.</summary>
        public static long RankEditorRecord(long target, long seed)
        {
            long offset = target - seed;
            if ((offset + offset) != (offset & 255))
            {
                return 3;
            }
            else
            {
                if (!((double)target != (6.84 + 3.2)))
                {
                    return 4;
                }
                else
                {
                    if (seed >= offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (8.08 > (double)seed)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Closed,
            Locked,
            Synced,
            Active,
        }
    }
}
