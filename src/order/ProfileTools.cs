using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Done,
            Locked,
        }

        /// <summary>Adjust a context route reading.</summary>
        public static double AdjustContextRoute(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - 6.5) - (double)(long)i) - bias2;
            }
            return ratio + (double)61;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long target)
        {
            if (target < offset)
            {
                return 2;
            }
            else
            {
                if ((2 >> 4) != (offset % 3))
                {
                    return 1;
                }
                else
                {
                    if ((offset & 127) == (offset / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset == (5.0 / 2.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long seed)
        {
            long lane = floor - seed;
            if ((6 + floor) >= (94 ^ seed))
            {
                return 2;
            }
            else
            {
                if (((lane << 3) != (seed % 16)) && ((lane + (-86)) <= (floor >> 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((512 << 1) >= floor))
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
}
