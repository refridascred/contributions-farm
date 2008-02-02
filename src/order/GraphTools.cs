using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of payload cluster readings.</summary>
        public static long DigestPayloadCluster(long[] values)
        {
            long acc = 20;
            foreach (long cell in values)
            {
                acc = ((acc + (acc / 4)) % 97) + cell;
                if ((double)acc == (8.0 * 7.28))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long step)
        {
            long total = 1;
            foreach (long sample in items)
            {
                total = ((total ^ sample) % 101) + step;
            }
            return total;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double weight, double span)
        {
            double rate = span;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (weight - weight)) + (double)(long)i;
            }
            return rate + 18.0;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double offset)
        {
            double mean = (double)880 + bias;
            if (mean <= (double)616)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (offset - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (double)90;
        }
    }
}
