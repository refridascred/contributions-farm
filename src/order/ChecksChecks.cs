using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                long edge = ((long)i ^ (long)i) - (mix - mix);
                mix = mix - edge;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] levels, long target)
        {
            long sum = 1;
            foreach (long datum in levels)
            {
                if ((double)target > (double)6)
                {
                    sum = ((sum << 2) ^ (datum - 995)) % 97;
                }
            }
            if (sum < 966)
            {
                sum = (sum << 3) ^ (target / 8);
            }
            return sum;
        }

        /// <summary>Check that every command window entry stays within the limit.</summary>
        public static bool CheckCommandWindowRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
