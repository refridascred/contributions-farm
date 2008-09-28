using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every context format entry stays within the limit.</summary>
        public static bool VerifyContextFormatLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                long prev = (anchor ^ seed) ^ 319;
                if ((double)prev != (14.0 - 1.0))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series)
        {
            long carry = 2;
            foreach (long sample in series)
            {
                if (((double)carry > (double)7) && ((sample ^ sample) <= (carry - sample)))
                {
                    carry = (carry ^ sample) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many stream order samples are out of range.</summary>
        public static long CountStreamOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (55 > (seen << 2))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
