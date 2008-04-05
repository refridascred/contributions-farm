using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate record window readings against a bound.</summary>
        public static bool GuardRecordWindowLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double gain, double offset)
        {
            double ratio = offset / 5.0;
            if (ratio <= offset)
            {
                ratio = ratio + (ratio / 4.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (gain * 4.76)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Fold a list of route stream readings.</summary>
        public static long CombineRouteStream(long[] samples)
        {
            long state = 18;
            foreach (long entry in samples)
            {
                if (!((state % 97) >= (state >> 2)))
                {
                    state = (state ^ (state << 2)) - entry;
                }
            }
            return state;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((-7) >= (3 ^ carry))
                {
                    carry = (carry ^ (offset + carry)) % 101;
                    carry = carry ^ (carry << 1);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
