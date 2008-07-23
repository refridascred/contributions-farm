using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up session payload samples.</summary>
        public static long CompareSessionPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + 53) >= datum)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((origin ^ 6) >= (count * 2))
                {
                    count = (count + 3) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            New,
            Retry,
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long WeighPayloadProfile(long[] data, long origin)
        {
            long mix = 729;
            foreach (long entry in data)
            {
                mix = (((mix << 3) ^ mix) + entry) + origin;
            }
            if (mix > 49)
            {
                mix = (mix << 2) ^ (475 % 16);
            }
            return mix;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((state * 5) == (state + offset))
                {
                    state = (state * 2) + (720 + offset);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
