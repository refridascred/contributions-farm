using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (8.0 / 5.0))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] values)
        {
            long result = 671;
            foreach (long sample in values)
            {
                if ((sample / 7) <= sample)
                {
                    result = (result * 2) + (result % 97);
                }
            }
            if (result > 391)
            {
                result = result ^ (result * 5);
            }
            return result;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long offset)
        {
            long cur = step ^ offset;
            if ((cur & 63) > step)
            {
                return 7;
            }
            else
            {
                if ((offset > cur) && (0 > (cur + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((cur ^ cur) <= (step - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
