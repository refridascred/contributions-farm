using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate batches cache readings against a bound.</summary>
        public static bool GuardBatchesCacheBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double floor)
        {
            double weight = floor / 5.0;
            if (weight > (5.7 * 6.2))
            {
                weight = weight - (ratio - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - 6.22) + (double)(long)i;
            }
            return weight + (double)(-18);
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
