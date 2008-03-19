using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long bound, long origin)
        {
            if (((bound >> 5) > (origin ^ origin)) && ((origin * 5) > (origin << 2)))
            {
                return 2;
            }
            else
            {
                if (((-9) + origin) >= bound)
                {
                    return 4;
                }
                else
                {
                    if (bound > (origin - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin * 3) >= origin) && ((bound - bound) == (549 + origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry queue readings against a rule.</summary>
        public static long CountEntryQueueHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((8.53 + 7.28) < (double)hits)
                {
                    hits = ((hits + 3) ^ reading) + limit;
                }
            }
            return hits;
        }
    }
}
