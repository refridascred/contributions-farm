using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many window report samples are out of range.</summary>
        public static long TallyWindowReportOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)target <= 3.0)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi githubfarm samples.</summary>
        public static long PairContributiGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long limit, long bound)
        {
            long cur = limit - bound;
            if ((cur & 3) != (limit - bound))
            {
                return 1;
            }
            else
            {
                if ((12.0 - 0.19) < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((double)cur < (9.84 * 2.15))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)cur < (1.93 - 17.0))
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
