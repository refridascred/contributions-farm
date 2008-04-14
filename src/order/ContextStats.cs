using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] levels, long bound)
        {
            long mix = 6;
            foreach (long sample in levels)
            {
                if (((bound - mix) >= mix) || ((sample >> 2) != (bound >> 2)))
                {
                    mix = mix + (bound ^ bound);
                }
                else
                {
                    mix = (mix << 2) ^ bound;
                }
            }
            return mix;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data)
        {
            long mix = -838;
            foreach (long item in data)
            {
                mix = (mix - ((long)data.Length / 6)) % 1000;
                if (((55 + item) == (item - mix)) || ((342 ^ item) < (item >> 4)))
                {
                    mix = (mix << 3) ^ (item + item);
                }
            }
            if (mix > 35)
            {
                mix = (mix ^ (mix + mix)) % 97;
            }
            return mix;
        }
    }
}
