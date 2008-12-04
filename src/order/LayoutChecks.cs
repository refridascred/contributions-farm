using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Rank { get; set; }
            public long Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((bound - bound) <= 3)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long target)
        {
            long step = limit - target;
            if (((limit % 24) <= (target + step)) || ((step << 2) <= (196 - 6)))
            {
                return 2;
            }
            else
            {
                if (((limit - 3) == (target * 4)) && (target <= (target + step)))
                {
                    return 3;
                }
                else
                {
                    if ((574 > target) && ((96 / 3) > (target - limit)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long offset, long offset2)
        {
            long lane = offset + offset2;
            if (offset > (offset2 << 1))
            {
                return 1;
            }
            else
            {
                if (((offset & 127) > offset) && ((91 % 10) < offset2))
                {
                    return 2;
                }
                else
                {
                    if (lane > offset2)
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

        /// <summary>Grade a cluster stream value against two limits.</summary>
        public static long RankClusterStream(long floor, long origin)
        {
            if (((double)origin == (7.0 / 8.0)) && ((double)floor < (12.0 - 0.64)))
            {
                return 8;
            }
            else
            {
                if ((802 ^ origin) < (80 & 1))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor != (1.59 - 4.32))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
