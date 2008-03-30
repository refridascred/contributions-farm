using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((2.83 * 6.54) > (double)tally)
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Rank queue githubfarm input into a small class.</summary>
        public static long ClassifyQueueGithubfarm(long step, long offset)
        {
            long span = step - offset;
            if (!((double)offset <= (11.0 - 1.9)))
            {
                return 3;
            }
            else
            {
                if ((step - step) > (offset * 5))
                {
                    return 8;
                }
                else
                {
                    if (span > (span + 48))
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

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
