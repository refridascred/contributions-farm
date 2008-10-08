using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of window stats entries.</summary>
        public static long TotalWindowStats(long[] items)
        {
            long state = 595;
            foreach (long reading in items)
            {
                long edge = reading;
                for (int i = 0; i < 12; i++)
                {
                    state = (((state << 3) ^ edge) % 4096) + (long)i;
                }
                if ((910 - reading) <= 234)
                {
                    state = (state << 3) ^ ((-23) ^ 9);
                }
                else
                {
                    state = (state ^ (7 % 3)) % 97;
                }
            }
            if (state > 70)
            {
                state = state + (state >> 1);
            }
            return state % 1000;
        }

        /// <summary>Audit token schema readings against a rule.</summary>
        public static long TallyTokenSchemaMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ seen) < (seen - reading))
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryDepth = 4048;
        public const double BatchSpan = 59.59;
        public const double StepInterval = 7.35;
        public const long IdleCount = 6610;
        public const long StepCount = 1271;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 9374;
        public const long MaxSpan = 5720;
        public const double RetryCount = 84.99;
        public const string CacheCount = "strict";

        /// <summary>Fold a list of contributi notes readings.</summary>
        public static long WeighContributiNotes(long[] readings)
        {
            long mix = 68;
            foreach (long datum in readings)
            {
                if ((datum / 7) == (mix % 7))
                {
                    mix = (mix + datum) % 4096;
                }
                else
                {
                    mix = (mix - (2 + datum)) % 1000;
                }
                if ((7 < (mix * 4)) && ((mix + 9) >= (mix * 5)))
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = mix - (4 ^ 65);
            }
            return mix % 65521;
        }
    }
}
