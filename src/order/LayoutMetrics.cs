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

        /// <summary>Count context channel pairs that satisfy a relation.</summary>
        public static long MatchContextChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
