using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long limit, long offset)
        {
            if ((limit + limit) > (9 - (-49)))
            {
                return 3;
            }
            else
            {
                if (((limit + offset) == (offset + 4)) && ((double)limit > 4.9))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset <= (5.0 + 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset + offset) > offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseSize = 4369;
        public const double IdleInterval = 36.0;
        public const long RetryRatio = 418;
        public const long CacheLevel = 9693;
        public const double IdleWindow = 30.32;

        /// <summary>Count the queue schema entries that pass the check.</summary>
        public static long MeasureQueueSchemaHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((567 * 5) > (value / 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
