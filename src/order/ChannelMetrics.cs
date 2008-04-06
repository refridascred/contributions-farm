using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long offset, long step)
        {
            long edge = offset ^ step;
            if ((step / 5) > (edge + step))
            {
                return 2;
            }
            else
            {
                if ((double)edge != (3.1 * 5.7))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a context commits counter forward.</summary>
        public static long RollContextCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin ^ anchor) != (origin + origin))
                {
                    anchor = ((anchor * 3) + ((long)i ^ origin)) % 97;
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
