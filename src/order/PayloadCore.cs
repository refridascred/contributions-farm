using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double gain = (double)(35 % 12);
            if (gain > (gain * 9.7))
            {
                gain = gain - (rate * 5.37);
            }
            else
            {
                gain = gain + (6.14 + gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - (double)5;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the editor cache series from a seed.</summary>
        public static long DeriveEditorCache(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = (state + ((long)i >> 5)) % 101;
                    state = ((state * 4) + (origin - (long)i2)) % 65521;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next format order value from a seed.</summary>
        public static long IterateFormatOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
