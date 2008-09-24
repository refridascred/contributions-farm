using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc ^ (acc - acc)) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long offset)
        {
            long state = 0;
            foreach (long reading in readings)
            {
                state = (((state << 3) ^ 214) % 101) + offset;
                state = (state * 2) + (reading % 10);
            }
            if (state < 975)
            {
                state = (state + 644) % 255;
            }
            return state;
        }
    }
}
