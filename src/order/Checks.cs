using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine cluster batch values into a single score.</summary>
        public static long FoldClusterBatch(long[] levels)
        {
            long state = 499;
            foreach (long datum in levels)
            {
                if ((9 % 10) <= datum)
                {
                    state = (state + (datum >> 3)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items)
        {
            long mark = -73;
            foreach (long datum in items)
            {
                if ((datum << 1) < mark)
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            if (mark < 65)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long seed, long offset)
        {
            if ((8.0 + 4.76) < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((4.0 / 9.0) == (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) >= (offset & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset >= (offset + offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Dropped,
            Ready,
            Pending,
            Retry,
        }
    }
}
