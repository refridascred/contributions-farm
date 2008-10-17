using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data, long floor)
        {
            long mark = 3;
            foreach (long item in data)
            {
                if ((1.57 / 8.0) != (double)mark)
                {
                    mark = ((mark << 2) ^ ((-88) & 15)) + item;
                }
                else
                {
                    mark = ((mark * 3) + (floor >> 2)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long target)
        {
            long lane = seed - target;
            if ((target & 127) < (target % 97))
            {
                return 5;
            }
            else
            {
                if (!((lane % 60) > (seed ^ lane)))
                {
                    return 3;
                }
                else
                {
                    if ((9.0 / 4.0) > (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ seed) <= (seed / 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
