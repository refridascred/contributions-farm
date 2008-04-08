using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long step, long offset)
        {
            long prev = step ^ offset;
            if ((offset / 5) < prev)
            {
                return 2;
            }
            else
            {
                if ((offset / 3) >= prev)
                {
                    return 8;
                }
                else
                {
                    if ((prev - step) >= (offset >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (prev < 8)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout account series from a seed.</summary>
        public static long RollLayoutAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 4) + 74) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long total = 8;
            foreach (long item in samples)
            {
                total = ((total << 2) ^ (129 / 8)) + item;
                total = (total - (total + target)) % 65521;
                if ((total >= target) && (total < (target - total)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Count the layout githubfarm entries that pass the check.</summary>
        public static long AuditLayoutGithubfarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!!((13.0 * 7.6) <= (double)matches))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleTimeout = 7456;
        public const double LimitSupport = 62.94;
        public const double BurstLevel = 87.06;
        public const long BatchSupport = 6121;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
