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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((9.09 + 5.24) <= (double)offset)
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Roll a payload graph counter forward.</summary>
        public static long StepPayloadGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = score + floor;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
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
