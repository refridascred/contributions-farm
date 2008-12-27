using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((((3.0 / 6.0) >= (double)(long)items.Length) || (760 >= sample)) && ((6.0 * 13.0) <= (double)(long)items.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((count < (370 % 10)) && (count > (count ^ sample))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long target)
        {
            long edge = origin ^ target;
            if ((target >= origin) || (1 <= (origin + edge)))
            {
                return 4;
            }
            else
            {
                if (origin >= (edge - target))
                {
                    return 2;
                }
                else
                {
                    if ((edge >= (988 + origin)) && ((double)edge == (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin * 5) == (edge / 4)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits & 15) == ((long)levels.Length + hits))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
