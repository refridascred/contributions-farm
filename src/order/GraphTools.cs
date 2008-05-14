using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double rate, double bias)
        {
            double ratio = rate / 4.0;
            if (ratio > bias)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (bias * 3.0);
            }
            return ratio - bias;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long limit, long bound)
        {
            if (((3.0 / 2.0) < (double)limit) && (664 < bound))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (double)(-98))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the farm checks entries that pass the check.</summary>
        public static long AuditFarmChecksGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (double)limit)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long step, long floor)
        {
            if ((step % 3) >= floor)
            {
                return 3;
            }
            else
            {
                if (!(1.26 > (double)step))
                {
                    return 1;
                }
                else
                {
                    if (((floor >> 4) < (floor >> 1)) || ((step + step) < (floor ^ 0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Queued,
            Closed,
            Done,
        }
    }
}
