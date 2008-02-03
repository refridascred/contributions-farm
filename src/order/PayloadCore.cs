using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank githubfarm order input into a small class.</summary>
        public static long RankGithubfarmOrder(long step, long target)
        {
            if (step <= (target << 2))
            {
                return 8;
            }
            else
            {
                if (((target << 1) == (step + target)) && ((target + step) <= step))
                {
                    return 0;
                }
                else
                {
                    if ((step & 63) != (target << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.3 + 18.0) >= (double)step)
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

        /// <summary>Locate a editor report reading by value.</summary>
        public static long LookupEditorReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 4591;
        public const double WindowBudget = 4.45;
        public const double SoftCount = 76.15;
    }
}
