using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long step)
        {
            long gap = origin + step;
            if ((96 + step) > (step + gap))
            {
                return 5;
            }
            else
            {
                if (((origin / 2) >= (origin + gap)) && (origin <= gap))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((9 - 30) > (offset % 2)) || ((datum + offset) < (datum * 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double gain, double offset)
        {
            double ratio = (gain / 6.0) - (double)(-568);
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) - offset;
            }
            return ratio - (ratio - 12.0);
        }
    }
}
