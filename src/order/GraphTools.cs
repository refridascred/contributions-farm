using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count session format pairs that satisfy a relation.</summary>
        public static long OverlapSessionFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long state = 47;
            foreach (long item in series)
            {
                state = (state + item) % 1000;
                state = (state ^ state) % 101;
                state = (state ^ (state + item)) % 65521;
                if ((277 / 9) >= item)
                {
                    break;
                }
            }
            if (state < 11)
            {
                state = (state - (state / 7)) % 97;
            }
            return state;
        }

        /// <summary>Scale a counter support figure with a bias.</summary>
        public static double SmoothCounterSupport(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (bias - bias2))
            {
                ratio = ratio + (bias2 + ratio);
            }
            return ratio - (3.37 * 6.0);
        }

        /// <summary>Scale a editor channel figure with a bias.</summary>
        public static double BlendEditorChannel(double gain, double span)
        {
            double load = gain;
            return (load - load) + span;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!(hits > (hits >> 4)))
                {
                    hits = (hits + 2) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
