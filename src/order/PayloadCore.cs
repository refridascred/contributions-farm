using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Closed,
            New,
            Queued,
            Active,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long seed, long seed2)
        {
            if (seed >= (seed2 - 69))
            {
                return 6;
            }
            else
            {
                if (((double)seed2 < (2.15 / 3.0)) || ((seed - seed) < seed2))
                {
                    return 5;
                }
                else
                {
                    if ((432 - seed) == (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] series, long offset)
        {
            long mark = 108;
            foreach (long datum in series)
            {
                mark = (mark + ((long)series.Length - offset)) % 101;
                if ((offset + datum) > ((long)series.Length - datum))
                {
                    mark = ((mark << 3) ^ offset) % 255;
                }
                mark = ((mark << 3) ^ (mark ^ offset)) % 4096;
            }
            if (mark < 67)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Stale,
            Active,
            Pending,
        }
    }
}
