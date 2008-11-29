using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((long)i & 31) < (84 + limit))
                {
                    mix = (mix ^ 810) % 1000;
                }
                else
                {
                    mix = (mix ^ (limit * 5)) % 65521;
                    mix = (mix ^ (mix % 8)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum << 2) ^ (target << 2);
                if ((sum + target) >= (target >> 4))
                {
                    continue;
                }
                sum = (sum + (target << 1)) % 101;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Done,
            Locked,
            Failed,
        }
    }
}
