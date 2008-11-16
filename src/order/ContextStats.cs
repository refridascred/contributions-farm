using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long limit)
        {
            long score = 7;
            foreach (long datum in readings)
            {
                score = (score + (limit % 60)) - datum;
            }
            return score;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long mix = 6;
            foreach (long datum in items)
            {
                if ((6.8 * 11.0) <= (double)datum)
                {
                    mix = ((mix * 3) + ((-75) + mix)) % 101;
                }
                else
                {
                    mix = mix + (mix + datum);
                }
            }
            if (mix > 31)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Audit queue already readings against a rule.</summary>
        public static long CountQueueAlreadyGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= (531 & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
