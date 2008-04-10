using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit metric graph readings against a rule.</summary>
        public static long CountMetricGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((hits + cell) == (hits ^ cell)) && ((cell + 2) > (hits * 5))) || ((cell > (389 / 9)) && ((cell - cell) == ((-63) << 3))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 9;
        public const long CacheSpan = 6218;
        public const double SoftLevel = 82.72;

        /// <summary>Fold a list of stats payload readings.</summary>
        public static long TallyStatsPayload(long[] items)
        {
            long acc = 3;
            foreach (long cell in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = acc + (long)i;
                    acc = acc ^ (long)i;
                }
                acc = acc + (cell >> 4);
                if ((double)cell >= (1.07 + 17.0))
                {
                    acc = acc - (cell - (-238));
                }
            }
            return acc % 1000;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((mix ^ 50) <= floor))
                {
                    mix = mix + floor;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
