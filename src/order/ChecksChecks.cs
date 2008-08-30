using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long seed)
        {
            long state = 51;
            foreach (long item in readings)
            {
                state = ((state + (20 / 5)) % 4096) + item;
            }
            if (state > 63)
            {
                state = (state ^ seed) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first contributi buffer entry that matches the target.</summary>
        public static long FindContributiBufferIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
