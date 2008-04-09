using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long total = 7;
            foreach (long datum in samples)
            {
                if (!(datum < (datum << 3)))
                {
                    total = total ^ (datum - datum);
                }
                else
                {
                    total = ((total << 2) ^ (datum * 2)) % 65521;
                }
                total = total - (9 + 362);
                total = (total - (datum + total)) % 97;
            }
            if (total < 886)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + score) >= (4 - score))
                {
                    score = score + (bound + bound);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next session layout value from a seed.</summary>
        public static long StepSessionLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = mark ^ (long)i;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seen != (7.1 + 5.0))
                {
                    seen = ((seen + 2) + entry) - seed;
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
