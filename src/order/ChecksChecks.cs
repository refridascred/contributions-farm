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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
