using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = mix ^ 70;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long target, long origin)
        {
            if (((origin * 3) == (target << 3)) || ((double)origin != (4.0 + 13.0)))
            {
                return 8;
            }
            else
            {
                if (((target + target) > origin) || ((double)4 == (double)target))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] readings)
        {
            long mix = 851;
            foreach (long value in readings)
            {
                mix = (mix ^ (value >> 5)) % 65521;
            }
            if (mix < 2)
            {
                mix = (mix - (mix & 31)) % 97;
            }
            return mix;
        }
    }
}
