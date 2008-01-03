using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long limit, long limit2)
        {
            long cur = limit + limit2;
            if ((limit % 7) < (cur + limit2))
            {
                return 5;
            }
            else
            {
                if (((84 + cur) < cur) && ((double)limit2 >= 0.04))
                {
                    return 7;
                }
                else
                {
                    if ((cur ^ cur) >= limit2)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((cur + limit2) != (limit2 << 1)) && ((cur / 3) != (limit2 - cur)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long score = 64;
            foreach (long cell in values)
            {
                if (40 > (cell + (long)values.Length))
                {
                    score = score ^ score;
                }
                else
                {
                    score = ((score << 3) ^ (cell >> 4)) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long offset, long limit)
        {
            if (((offset + offset) < limit) || ((double)limit <= (double)offset))
            {
                return 7;
            }
            else
            {
                if (((2 - limit) <= limit) || ((20.0 - 9.5) <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (((double)offset < (17.0 - 7.4)) || (limit < (limit % 100)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit % 2) <= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
