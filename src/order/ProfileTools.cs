using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mix = 48;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + ((long)readings.Length - (-766))) ^ cell;
            }
            return mix % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 6757;
        public const double WindowRatio = 83.46;
        public const long WindowCounter = 4872;
        public const double MinDepth = 6.27;
        public const long SoftCounter = 2272;

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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long origin)
        {
            long span = offset - origin;
            if ((double)offset == (double)645)
            {
                return 4;
            }
            else
            {
                if ((origin < offset) && ((span + offset) < origin))
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ 6) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset <= (5.72 - 2.08))
                        {
                            return 6;
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
}
