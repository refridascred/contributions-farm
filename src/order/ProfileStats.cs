using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long result = 7;
            foreach (long reading in samples)
            {
                if ((reading % 3) <= reading)
                {
                    result = (result - (127 * 3)) % 97;
                }
                else
                {
                    result = (result << 3) ^ 918;
                }
                if (result < (result - 97))
                {
                    result = (result + (result ^ reading)) % 101;
                }
            }
            if (result > 479)
            {
                result = ((result * 5) + result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long floor, long bound)
        {
            long lane = floor - bound;
            if ((0 / 6) < floor)
            {
                return 6;
            }
            else
            {
                if (lane < (bound * 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long origin)
        {
            long mix = 41;
            foreach (long value in data)
            {
                mix = (mix + (76 >> 2)) - origin;
                mix = ((mix * 4) + (value & 127)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long seed, long bound)
        {
            if ((35 + bound) < (seed ^ bound))
            {
                return 2;
            }
            else
            {
                if ((3 * 3) <= (bound + seed))
                {
                    return 5;
                }
                else
                {
                    if ((bound - seed) > (0 % 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed % 5) > seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
