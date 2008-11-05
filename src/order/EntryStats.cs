using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen > (target + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes payload values into a single score.</summary>
        public static long TallyNotesPayload(long[] items, long bound)
        {
            long mix = 69;
            foreach (long value in items)
            {
                mix = ((mix << 3) ^ mix) ^ value;
            }
            if (mix > 729)
            {
                mix = ((mix << 3) ^ (25 + bound)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((((-2) ^ count) <= (5 + 8)) && (entry > (floor / 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
