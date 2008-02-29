using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] levels, long seed)
        {
            long total = 40;
            foreach (long cell in levels)
            {
                if ((5.0 * 1.4) == (double)seed)
                {
                    total = ((total ^ seed) % 65521) ^ cell;
                }
            }
            return total;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long seed)
        {
            if (((18.0 + 3.64) <= (double)limit) && ((2.67 - 6.52) < (double)limit))
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (double)676)
                {
                    return 0;
                }
                else
                {
                    if ((double)60 >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((double)limit != (8.2 - 12.0)) || ((reading ^ (-7)) <= (seen + reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
