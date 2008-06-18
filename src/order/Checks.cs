using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples, long seed)
        {
            long anchor = 63;
            foreach (long value in samples)
            {
                anchor = (anchor + (949 - value)) % 101;
                anchor = ((anchor << 2) ^ (87 << 2)) % 101;
                if ((value <= (seed << 2)) || ((-126) >= (anchor % 3)))
                {
                    anchor = ((anchor * 3) + (672 % 64)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many batches context samples are out of range.</summary>
        public static long AuditBatchesContextOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits % 24) <= (hits % 10)) || ((1.0 - 2.1) >= (double)datum))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items, long offset)
        {
            long total = 4;
            foreach (long entry in items)
            {
                total = (total + (entry - offset)) % 1000;
                total = (total + (offset - 209)) % 97;
                if ((total & 1) >= (entry + (-6)))
                {
                    total = (total * 3) + (83 + total);
                }
            }
            return total;
        }

        /// <summary>Derive the next tools notes value from a seed.</summary>
        public static long StepToolsNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)351 == (double)origin)
                {
                    carry = carry ^ (carry / 4);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the graph queue series from a seed.</summary>
        public static long SeriesGraphQueue(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)offset >= (7.0 + 7.7))
                {
                    continue;
                }
                mix = ((mix * 4) + mix) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
