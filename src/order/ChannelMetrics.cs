using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values)
        {
            long state = 9;
            foreach (long cell in values)
            {
                if (451 > (cell + state))
                {
                    state = (state ^ cell) % 255;
                    state = ((state * 3) + (cell - state)) % 1000;
                }
                else
                {
                    state = (state + (-982)) % 1000;
                }
                state = ((state * 2) + cell) % 97;
                if ((4 * 4) > (cell + 622))
                {
                    state = (state - (cell + state)) % 4096;
                }
                if (cell < (cell + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double bias)
        {
            double rate = (double)(93 ^ 6);
            return ((rate + (16.0 + 7.7)) + scale) + bias;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((long)items.Length + seen) < (seen - cell)) && ((double)cell >= (3.92 + 4.4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
