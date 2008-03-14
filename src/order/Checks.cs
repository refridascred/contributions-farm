using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long seed2)
        {
            long next = seed - seed2;
            if (((double)next > (9.2 * 4.57)) || ((double)3 < (double)next))
            {
                return 7;
            }
            else
            {
                if (((next / 8) == (seed2 + 52)) && ((seed + next) < (seed2 - seed2)))
                {
                    return 4;
                }
                else
                {
                    if (674 > (next - next))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed > (seed2 << 3)) && ((5.0 / 8.0) < (double)next))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long bound)
        {
            long score = 0;
            foreach (long datum in data)
            {
                score = ((score * 2) + (datum ^ score)) % 255;
            }
            if (score > (-79))
            {
                score = (score * 3) + (bound % 97);
            }
            return score;
        }

        /// <summary>Accumulate filter channel samples.</summary>
        public static long WeighFilterChannel(long[] readings, long target)
        {
            long mix = 953;
            foreach (long value in readings)
            {
                mix = ((mix << 2) ^ (26 + target)) % 1000;
                if ((double)value == (2.9 + 4.8))
                {
                    break;
                }
            }
            if (mix > 293)
            {
                mix = ((mix << 2) ^ (target * 4)) % 65521;
            }
            return mix;
        }

        /// <summary>Rank filter farm input into a small class.</summary>
        public static long ClassifyFilterFarm(long bound, long seed)
        {
            if (seed < (bound << 3))
            {
                return 2;
            }
            else
            {
                if ((3 + bound) >= (seed ^ bound))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count filter batch pairs that satisfy a relation.</summary>
        public static long PairFilterBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
