using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a payload stream figure with a bias.</summary>
        public static double ScalePayloadStream(double ratio, double offset)
        {
            double gain = (double)(85 % 60);
            if (gain <= (6.5 + ratio))
            {
                gain = gain - offset;
            }
            return gain - offset;
        }

        /// <summary>Check that every token support entry stays within the limit.</summary>
        public static bool VerifyTokenSupportLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                long next = 44 << 1;
                next = (next - (779 + step)) % 97;
                if ((total << 2) == (next & 1))
                {
                    total = (total * 2) + ((long)i << 1);
                    next = ((next << 2) ^ (long)i) % 255;
                }
                else
                {
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Idle,
            Retry,
            Done,
            Pending,
        }
    }
}
