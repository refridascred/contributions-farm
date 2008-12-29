using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Closed,
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Classify a route channel pair into a bucket.</summary>
        public static long ClassifyRouteChannel(long step, long seed)
        {
            long diff = step + seed;
            if (!((diff * 4) < (571 + 9)))
            {
                return 5;
            }
            else
            {
                if (!((step - seed) == (seed * 3)))
                {
                    return 6;
                }
                else
                {
                    if (seed <= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((diff << 1) > (diff ^ diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)origin == (double)hits)
                {
                    hits = (hits + 2) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
