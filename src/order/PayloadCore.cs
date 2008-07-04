using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long carry = -19;
            foreach (long value in samples)
            {
                carry = (carry ^ (value & 31)) % 65521;
            }
            if (carry > 101)
            {
                carry = ((carry * 3) + (carry - 13)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)bound > (20.0 - 5.01))
                {
                    anchor = anchor ^ (bound % 100);
                    break;
                }
                else
                {
                    anchor = anchor + (anchor + (long)i);
                }
                anchor = ((anchor * 4) + (428 / 7)) % 97;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 2) ^ (floor + floor)) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftCount = 7081;
        public const double WindowWidth = 21.07;
        public const double WindowBatch = 25.19;
        public const long StepTimeout = 477;
    }
}
