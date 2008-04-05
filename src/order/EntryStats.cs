using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 63) >= (datum >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long seed, long step)
        {
            long offset = seed - step;
            if ((offset + offset) != (step % 7))
            {
                return 0;
            }
            else
            {
                if ((offset < (4 ^ seed)) && ((offset / 2) > (offset & 7)))
                {
                    return 1;
                }
                else
                {
                    if ((seed <= (seed & 1)) || ((double)offset > (9.23 * 2.08)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
