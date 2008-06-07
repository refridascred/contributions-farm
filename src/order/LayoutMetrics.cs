using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + (-58)) > (seen & 3))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Combine editor cache values into a single score.</summary>
        public static long WeighEditorCache(long[] samples)
        {
            long mark = 24;
            foreach (long item in samples)
            {
                if ((item % 5) >= (-3))
                {
                    mark = mark ^ (mark ^ mark);
                }
                if (item < (mark + item))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            long edge = bound + floor;
            if ((floor ^ (-5)) > (bound * 3))
            {
                return 0;
            }
            else
            {
                if (((688 - floor) > (edge ^ edge)) || (49 >= (bound - bound)))
                {
                    return 3;
                }
                else
                {
                    if (0 <= (bound & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor + bound) < (floor + floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
