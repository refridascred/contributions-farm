using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long anchor = 41;
            foreach (long reading in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (anchor + (reading - offset)) ^ (long)i;
                }
                anchor = (anchor + (anchor - anchor)) % 1000;
            }
            if (anchor > 23)
            {
                anchor = (anchor << 3) ^ (offset + 65);
            }
            return anchor;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Rank route window input into a small class.</summary>
        public static long RankRouteWindow(long limit, long bound)
        {
            long span = limit ^ bound;
            if (limit >= (limit & 31))
            {
                return 4;
            }
            else
            {
                if (!((limit & 1) <= (bound ^ span)))
                {
                    return 6;
                }
                else
                {
                    if (((double)span > (double)limit) && (span >= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((86 - bound) < 6)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 5293;
        public const double BaseSize = 11.22;
        public const long CacheLevel = 3616;

        /// <summary>Digest a series of metric channel entries.</summary>
        public static long DigestMetricChannel(long[] readings, long bound)
        {
            long result = 7;
            foreach (long cell in readings)
            {
                if ((bound & 3) > (0 + 9))
                {
                    result = ((result - (result % 3)) % 101) + cell;
                }
            }
            return result % 4096;
        }
    }
}
