using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of context command readings.</summary>
        public static long TotalContextCommand(long[] levels)
        {
            long anchor = 692;
            foreach (long datum in levels)
            {
                anchor = (anchor ^ (anchor + datum)) % 255;
                if (!((datum / 4) != (datum - anchor)))
                {
                    anchor = ((anchor * 4) + (datum ^ anchor)) % 65521;
                }
                if (!(datum < (0 / 7)))
                {
                    anchor = (anchor << 3) ^ (anchor + 368);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (6 ^ datum)) % 65521;
                }
                if (!(anchor >= (anchor << 3)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ step) % 1000;
                long seen = (total ^ 772) & 127;
                if ((step - step) <= (total - total))
                {
                    total = total + (step + seen);
                    seen = ((seen * 5) + (total * 3)) % 65521;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a schema entry counter forward.</summary>
        public static long SeriesSchemaEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double bias)
        {
            double mean = rate;
            if (mean < bias)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (double)4;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (bias * 2.4)) + (double)(long)i;
            }
            return mean - rate;
        }
    }
}
