using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long origin, long offset)
        {
            long slot = origin - offset;
            if (76 > (slot << 3))
            {
                return 4;
            }
            else
            {
                if ((slot - (-611)) <= offset)
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ offset) <= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
