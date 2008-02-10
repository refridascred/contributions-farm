using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit metrics githubfarm readings against a rule.</summary>
        public static long MeasureMetricsGithubfarmOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) >= seen)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset + offset) > (offset * 2))
            {
                return 3;
            }
            else
            {
                if ((double)bound != (1.4 - 11.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin < (9.9 - 4.6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (4 < (seen + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
