using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit report support readings against a rule.</summary>
        public static long AuditReportSupportGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((count / 4) >= (52 ^ datum)) && !((double)datum <= 17.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] data, long limit)
        {
            long score = 2;
            foreach (long sample in data)
            {
                if ((double)sample > (6.9 * 2.6))
                {
                    score = (score + sample) - limit;
                }
                else
                {
                    score = score + sample;
                }
            }
            return score;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((4.27 + 0.09) > (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }
    }
}
