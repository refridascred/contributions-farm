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

        /// <summary>Count the notes layout entries that pass the check.</summary>
        public static long AuditNotesLayoutOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)step < (double)63)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
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
