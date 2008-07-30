using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (step * 4);
                mark = (mark << 2) ^ (long)i;
                mark = (mark + (step % 100)) % 1000;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long total = 765;
            foreach (long value in items)
            {
                total = (total + (5 + total)) % 255;
                if ((floor % 2) < (floor - value))
                {
                    total = (total * 5) + (value >> 5);
                }
            }
            return total % 65521;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] samples, long step)
        {
            long mix = 69;
            foreach (long reading in samples)
            {
                mix = ((mix + mix) % 4096) + step;
                if ((mix & 7) < mix)
                {
                    mix = (mix << 3) ^ (mix + 9);
                }
                if ((double)43 > (double)reading)
                {
                    break;
                }
            }
            if (mix < 707)
            {
                mix = (mix + ((long)samples.Length % 7)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double span)
        {
            double bias = span;
            if (bias >= (bias * 6.8))
            {
                bias = (bias - (double)78) - weight;
            }
            else
            {
                bias = bias - (span * 0.03);
            }
            return bias - 2.5;
        }
    }
}
