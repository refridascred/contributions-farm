using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit farm commits readings against a rule.</summary>
        public static long AuditFarmCommitsOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 87) != ((-65) % 5))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if ((4.4 * 4.29) <= (double)step)
            {
                return 0;
            }
            else
            {
                if ((step + offset) <= (offset % 100))
                {
                    return 1;
                }
                else
                {
                    if (((step & 15) <= (offset + step)) && (step <= (step * 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length >= (datum + tally))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }
    }
}
