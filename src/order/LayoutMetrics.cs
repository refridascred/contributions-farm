using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((seed - hits) != (value + hits))
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

        /// <summary>Digest a series of window farm entries.</summary>
        public static long TallyWindowFarm(long[] samples)
        {
            long carry = 69;
            foreach (long value in samples)
            {
                if (!(6 < (carry + 831)))
                {
                    carry = carry + (value % 10);
                }
                carry = (carry + (carry / 8)) % 1000;
            }
            return carry;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
