using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Pending,
            Queued,
            Ready,
            Closed,
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
