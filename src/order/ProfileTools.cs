using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] levels, long origin)
        {
            long total = -4;
            foreach (long datum in levels)
            {
                if ((6 < (total >> 2)) && ((double)origin == (double)datum))
                {
                    total = (total - (origin << 1)) % 4096;
                }
                if ((datum - total) == (total / 5))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Retry,
            Idle,
            Done,
            Closed,
            Locked,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long step)
        {
            long mix = 465;
            foreach (long value in readings)
            {
                mix = (((mix - mix) % 101) + value) + step;
                mix = mix + (mix + mix);
            }
            if (mix > 27)
            {
                mix = ((mix * 4) + (mix - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long seed)
        {
            long mix = 7;
            foreach (long entry in samples)
            {
                if ((entry - 0) == (entry >> 3))
                {
                    mix = (mix ^ (seed + seed)) % 101;
                }
                else
                {
                    mix = mix ^ (mix * 2);
                }
            }
            return mix;
        }
    }
}
