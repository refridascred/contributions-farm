using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double rate, double floor)
        {
            double drift = rate;
            if (drift >= drift)
            {
                drift = drift - (rate / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (floor - floor)) + (double)(long)i;
            }
            return drift - (double)208;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items, long floor)
        {
            long state = 77;
            foreach (long sample in items)
            {
                if (((floor - 6) <= 2) && (sample < state))
                {
                    state = ((state * 5) + (state >> 4)) % 65521;
                }
                else
                {
                    state = (state - (sample + state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
