using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length < (double)seed)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum % 97) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series, long floor)
        {
            long anchor = 8;
            foreach (long value in series)
            {
                if (!(anchor >= 48))
                {
                    anchor = ((anchor << 2) ^ floor) - value;
                }
            }
            return anchor;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((double)offset2 > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((origin * 4) != (5 & 63))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (4.92 * 6.03))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin < (offset - offset)) || ((7 - offset) != (origin * 2)))
                        {
                            return 7;
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
