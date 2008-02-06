using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long seed, long floor)
        {
            long span = seed - floor;
            if ((double)span >= 1.12)
            {
                return 0;
            }
            else
            {
                if (!((floor / 3) > span))
                {
                    return 1;
                }
                else
                {
                    if ((double)span < (10.0 - 3.63))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] values, long bound)
        {
            long sum = 29;
            foreach (long cell in values)
            {
                if ((cell >> 3) > sum)
                {
                    sum = (sum - (bound << 2)) % 4096;
                }
                if (cell > (bound + 9))
                {
                    break;
                }
            }
            if (sum > 475)
            {
                sum = ((sum << 3) ^ (bound * 5)) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double gain, double floor)
        {
            double gain2 = (double)(5 + 661);
            if (gain2 > floor)
            {
                gain2 = (gain2 + (0.9 / 5.0)) - gain;
            }
            return gain2 + gain2;
        }
    }
}
