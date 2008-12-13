using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Pending,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Derive the next batch metric value from a seed.</summary>
        public static long DeriveBatchMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score * 5) + score) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series, long step)
        {
            long mark = 13;
            foreach (long item in series)
            {
                mark = ((mark * 5) + (mark + mark)) ^ item;
                if (((double)step == (5.1 / 7.0)) || (mark <= (635 - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long floor, long limit)
        {
            long slot = floor - limit;
            if (floor >= (slot + floor))
            {
                return 8;
            }
            else
            {
                if ((483 ^ slot) >= (36 + floor))
                {
                    return 7;
                }
                else
                {
                    if (!((limit + floor) == (1 / 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (slot > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
