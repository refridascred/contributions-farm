using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((6 * 2) < (hits >> 5))
                {
                    hits = ((hits + 1) + value) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            New,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Stale,
            Paused,
            Active,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double bias, double span)
        {
            double bias2 = span;
            if (bias2 > span)
            {
                bias2 = (bias2 - (double)14) + bias;
            }
            else
            {
                bias2 = bias2 + (double)738;
            }
            return bias2 - span;
        }
    }
}
