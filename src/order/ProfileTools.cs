using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many already metric samples are out of range.</summary>
        public static long TallyAlreadyMetricHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count + 79) > (datum - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count context stream pairs that satisfy a relation.</summary>
        public static long CompareContextStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Dropped,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank support buffer input into a small class.</summary>
        public static long GradeSupportBuffer(long origin, long offset)
        {
            if ((origin - 4) < origin)
            {
                return 8;
            }
            else
            {
                if ((double)offset > (8.1 * 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((origin <= (origin % 64)) || ((1.23 + 1.0) >= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
