using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((limit - cell) < (tally + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double span)
        {
            double bias2 = (bias + bias) + span;
            if (bias2 >= (8.0 * 5.65))
            {
                bias2 = bias2 + (bias * 16.0);
            }
            else
            {
                bias2 = bias2 + (bias2 - 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + (double)(-984)) + (double)(long)i;
            }
            return bias2 - (bias * 2.95);
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                acc = (acc + ((long)series.Length % 100)) ^ cell;
            }
            if (acc > 664)
            {
                acc = (acc + (acc << 2)) % 101;
            }
            return acc % 65521;
        }
    }
}
