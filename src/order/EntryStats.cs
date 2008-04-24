using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of githubfarm schema readings.</summary>
        public static long WeighGithubfarmSchema(long[] samples)
        {
            long acc = 230;
            foreach (long item in samples)
            {
                if (acc <= (acc / 3))
                {
                    acc = (acc ^ (item % 60)) % 1000;
                }
            }
            if (acc > 33)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long origin, long limit)
        {
            long gap = origin ^ limit;
            if ((9.6 + 2.61) >= (double)gap)
            {
                return 3;
            }
            else
            {
                if ((gap * 4) > (limit << 3))
                {
                    return 0;
                }
                else
                {
                    if ((gap % 2) > (gap - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                long matches = (mark - origin) + 75;
                if ((matches - (long)i) <= matches)
                {
                    mark = (mark + (origin - mark)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 103;
        public const long MaxScore = 1477;
        public const long SoftCount = 2674;
        public const long WindowBudget = 1602;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
