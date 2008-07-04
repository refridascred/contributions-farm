using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = total + (floor - floor);
                total = (total ^ (total >> 3)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(seen > (seen ^ 18)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch context readings.</summary>
        public static long TallyBatchContext(long[] values, long offset)
        {
            long mix = -9;
            foreach (long datum in values)
            {
                mix = (((mix * 5) + datum) % 4096) + offset;
                mix = mix + mix;
                if ((mix <= (mix / 8)) || ((2 + (-8)) >= (datum & 127)))
                {
                    break;
                }
            }
            if (mix > 5)
            {
                mix = (mix << 3) ^ ((-89) - (long)values.Length);
            }
            return mix;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum / 5) < (datum % 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
