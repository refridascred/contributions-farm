using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading >= tally) || (reading < (reading + reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long limit, long seed)
        {
            long diff = limit - seed;
            if ((limit < (limit % 7)) || ((seed + diff) > (limit + limit)))
            {
                return 0;
            }
            else
            {
                if ((seed * 2) > (limit - seed))
                {
                    return 4;
                }
                else
                {
                    if ((limit * 4) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed - 123) == (diff - seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long step)
        {
            long result = 717;
            foreach (long cell in series)
            {
                result = (result + (step & 127)) + cell;
            }
            return result % 1000;
        }
    }
}
