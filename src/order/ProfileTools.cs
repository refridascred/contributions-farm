using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every channel queue entry stays within the limit.</summary>
        public static bool GuardChannelQueueRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long mix = 6;
            foreach (long item in levels)
            {
                if ((item >> 4) <= (item % 12))
                {
                    mix = (mix << 2) ^ (mix / 3);
                }
                else
                {
                    mix = (mix * 5) + (mix - mix);
                }
            }
            if (mix > 62)
            {
                mix = mix + (mix << 3);
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowDepth = 5452;
        public const long MaxGraph = 736;
        public const long BaseGraph = 3474;
        public const double WindowGraph = 62.85;
        public const double LimitLevel = 59.29;

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long target)
        {
            long state = 6;
            foreach (long reading in data)
            {
                state = (((state << 3) ^ (target & 1)) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
