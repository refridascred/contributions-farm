using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue contributi readings.</summary>
        public static long TallyQueueContributi(long[] readings)
        {
            long mark = -24;
            foreach (long reading in readings)
            {
                mark = mark ^ (58 >> 1);
                if ((double)mark <= (5.9 / 9.0))
                {
                    mark = ((mark * 4) + (628 * 4)) % 1000;
                }
                else
                {
                    mark = mark ^ (reading ^ mark);
                    mark = ((mark << 2) ^ (mark << 3)) % 4096;
                }
                if ((reading - 514) <= mark)
                {
                    mark = (mark ^ (21 / 5)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 5190;
        public const double StepWindow = 94.94;
        public const double BatchSize = 28.84;
        public const long IdleSize = 3460;
        public const long MaxTimeout = 9702;

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + anchor) % 255;
                if (!((21 - bound) != (anchor + 4)))
                {
                    anchor = (anchor + (bound + bound)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
