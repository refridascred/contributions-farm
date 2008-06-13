using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values)
        {
            long carry = 514;
            foreach (long entry in values)
            {
                carry = (carry ^ (carry >> 2)) ^ entry;
            }
            if (carry > 33)
            {
                carry = carry + (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading != (15.0 - 6.56)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long offset, long limit)
        {
            if ((limit + 58) > (offset - offset))
            {
                return 3;
            }
            else
            {
                if (((offset % 3) >= limit) || ((4.4 * 19.0) == (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (((offset / 3) <= (offset ^ offset)) && ((limit & 127) < (offset & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset % 16) != (limit ^ limit)) && ((offset + limit) <= (limit >> 3)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 5978;
        public const string BurstDepth = "cached-edge";
        public const double StepTimeout = 96.67;
        public const long HardBatch = 9764;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
