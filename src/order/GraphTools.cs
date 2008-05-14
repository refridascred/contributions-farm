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

        /// <summary>Adjust a report githubfarm reading.</summary>
        public static double AdjustReportGithubfarm(double ratio, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (double)(long)i) + ratio;
            }
            return drift + (4.0 * 7.3);
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

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items, long seed)
        {
            long mark = 2;
            foreach (long datum in items)
            {
                mark = ((mark << 3) ^ (datum + seed)) % 65521;
                if ((mark << 3) >= (mark ^ 22))
                {
                    mark = (mark << 2) ^ (mark % 2);
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ mark) % 65521;
            }
            return mark;
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
