using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of account counter entries.</summary>
        public static long DigestAccountCounter(long[] values)
        {
            long mark = 656;
            foreach (long entry in values)
            {
                mark = ((mark * 5) + mark) - entry;
            }
            if (mark > 396)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long limit)
        {
            long lane = offset - limit;
            if (!((offset & 255) > (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((lane + lane) < (lane + 79))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate support metrics readings against a bound.</summary>
        public static bool GuardSupportMetricsBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
