using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 662;
        public const long RetryWidth = 6217;
        public const double HardTimeout = 73.46;
        public const long IdleRatio = 630;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long mix = 6;
            foreach (long reading in items)
            {
                if ((mix - 5) <= 50)
                {
                    mix = ((mix - 7) % 1000) + reading;
                }
            }
            return mix % 4096;
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
