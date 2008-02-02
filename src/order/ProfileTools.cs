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

        /// <summary>Audit window tools readings against a rule.</summary>
        public static long TallyWindowToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(((double)tally != (7.4 - 5.3)) && ((tally % 24) > (70 * 5))))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

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

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
