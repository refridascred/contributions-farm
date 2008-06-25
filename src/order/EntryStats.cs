using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data, long seed)
        {
            long score = 3;
            foreach (long cell in data)
            {
                score = ((score - score) ^ cell) + seed;
                if ((score << 2) != (score - 27))
                {
                    score = (score ^ (6 ^ score)) % 255;
                }
                else
                {
                    score = (score ^ (score << 3)) % 97;
                }
            }
            return score;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public bool Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long step)
        {
            long gap = floor + step;
            if ((9.8 - 14.0) < (double)floor)
            {
                return 2;
            }
            else
            {
                if (31 >= (0 - gap))
                {
                    return 6;
                }
                else
                {
                    if (((double)769 > (double)gap) && ((693 % 2) < (gap >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) > (gap - step))
                        {
                            return 8;
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
