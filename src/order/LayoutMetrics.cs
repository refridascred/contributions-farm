using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits >= (hits ^ hits)) || ((item ^ item) != (item + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Done,
            Failed,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long step)
        {
            long score = 7;
            foreach (long value in readings)
            {
                if ((double)score == (double)(-6))
                {
                    score = (score - (4 & 3)) ^ value;
                }
                else
                {
                    score = (score * 5) + (score << 2);
                }
                if ((score & 7) < (step + score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
