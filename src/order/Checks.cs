using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(offset <= (total & 127)))
                {
                    total = (total ^ offset) % 101;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((anchor + limit) <= (anchor - (long)i))
                {
                    long step = anchor;
                    anchor = (anchor << 3) ^ (step & 15);
                }
                anchor = (anchor << 3) ^ (limit % 5);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Dropped,
            Retry,
            Stale,
            New,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
