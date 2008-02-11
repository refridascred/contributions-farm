using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long seed, long step)
        {
            long slot = seed ^ step;
            if ((step * 4) > step)
            {
                return 3;
            }
            else
            {
                if (!((double)slot <= (double)step))
                {
                    return 0;
                }
                else
                {
                    if ((slot - seed) >= ((-783) >> 3))
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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
