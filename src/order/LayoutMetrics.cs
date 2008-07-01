using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next token route value.</summary>
        public static double SmoothTokenRoute(double rate, double span)
        {
            double gain = rate + (rate * 3.8);
            if (gain <= (5.7 * 2.71))
            {
                gain = (gain - (rate - 4.5)) + span;
            }
            else
            {
                gain = gain + (0.09 / 2.0);
            }
            return gain - 5.98;
        }

        /// <summary>Combine queue editor values into a single score.</summary>
        public static long DigestQueueEditor(long[] readings)
        {
            long mark = 51;
            foreach (long item in readings)
            {
                if (!(mark <= (mark << 3)))
                {
                    mark = (mark ^ (item - mark)) % 255;
                }
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels)
        {
            long acc = 49;
            foreach (long datum in levels)
            {
                acc = ((acc * 4) + (29 % 7)) - datum;
            }
            return acc;
        }
    }
}
