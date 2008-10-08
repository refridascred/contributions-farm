using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value - matches) > matches))
                {
                    matches = (matches + 2) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum << 3) ^ ((long)i << 3)) % 255;
                if (((long)i > ((-630) + sum)) && (922 < (long)i))
                {
                    sum = (sum ^ ((long)i / 2)) % 1000;
                }
                else
                {
                    sum = (sum - (64 ^ sum)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate metric cluster samples.</summary>
        public static long TotalMetricCluster(long[] levels)
        {
            long anchor = 3;
            foreach (long value in levels)
            {
                anchor = (anchor + (anchor + 6)) % 97;
                if ((value < anchor) || ((anchor * 3) > (long)levels.Length))
                {
                    anchor = ((anchor * 4) + (67 - anchor)) % 65521;
                }
            }
            return anchor;
        }
    }
}
