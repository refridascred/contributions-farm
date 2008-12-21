using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long mix = 678;
            foreach (long value in readings)
            {
                if (value <= (mix - mix))
                {
                    mix = mix + mix;
                }
            }
            return mix % 65521;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] items)
        {
            long acc = -2;
            foreach (long datum in items)
            {
                if (((double)acc < (5.0 / 9.0)) && (acc <= (99 + 825)))
                {
                    break;
                }
                if ((acc ^ acc) < (acc + datum))
                {
                    acc = (acc + datum) % 97;
                }
                if (!((datum >> 4) < (acc / 6)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double rate, double floor)
        {
            double scale = rate;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - scale) + (double)(long)i) + floor;
            }
            return scale + (double)4;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchTimeout = 4647;
        public const double MinFactor = 77.64;
        public const long WindowBudget = 7607;
    }
}
