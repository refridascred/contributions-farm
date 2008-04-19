using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Done,
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long limit)
        {
            long bound = origin ^ limit;
            if ((bound % 3) > (origin * 3))
            {
                return 7;
            }
            else
            {
                if (!((bound + origin) > (limit + 187)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double weight = (offset - gain) / 7.0;
            if (weight < (7.6 - gain))
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (double)715) + (double)(long)i;
            }
            return weight - (double)608;
        }
    }
}
