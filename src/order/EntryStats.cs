using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine context cache values into a single score.</summary>
        public static long FoldContextCache(long[] values, long target)
        {
            long state = 1;
            foreach (long item in values)
            {
                if ((7.2 + 1.67) >= (double)state)
                {
                    state = ((state + (973 % 8)) ^ item) + target;
                }
            }
            return state;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series)
        {
            long mix = 378;
            foreach (long sample in series)
            {
                if ((455 - sample) == (mix >> 3))
                {
                    mix = mix - (229 << 3);
                }
                else
                {
                    mix = (mix + (sample / 6)) % 101;
                }
            }
            if (mix < 6)
            {
                mix = mix ^ (mix << 2);
            }
            return mix;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                if ((sample - 255) > (sample + state))
                {
                    state = state + (19 % 12);
                }
            }
            if (state < 95)
            {
                state = ((state << 3) ^ (state - state)) % 101;
            }
            return state % 65521;
        }
    }
}
