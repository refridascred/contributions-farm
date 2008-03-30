using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values, long floor)
        {
            long acc = 4;
            foreach (long item in values)
            {
                acc = ((acc - (acc - 85)) ^ item) + floor;
            }
            return acc;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double span)
        {
            double scale2 = (span / 4.0) / 5.0;
            if (scale2 >= scale2)
            {
                scale2 = (scale2 - span) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (scale2 - span)) + (double)(long)i;
            }
            return scale2 + (double)7;
        }

        /// <summary>Fold a list of account graph readings.</summary>
        public static long TallyAccountGraph(long[] samples)
        {
            long acc = -187;
            foreach (long cell in samples)
            {
                if ((cell ^ cell) != (cell >> 1))
                {
                    acc = (acc * 4) + (496 & 63);
                }
                if ((double)acc > (double)cell)
                {
                    break;
                }
            }
            if (acc > 112)
            {
                acc = acc - (acc / 8);
            }
            return acc;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples, long step)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                state = ((state ^ (state / 3)) ^ datum) + step;
            }
            return state % 4096;
        }
    }
}
