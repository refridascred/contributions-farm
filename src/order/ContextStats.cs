using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item > (item / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double rate, double span)
        {
            double load = (span - rate) + (span + 4.1);
            if (load <= span)
            {
                load = load + (rate + span);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (span - span)) + (double)(long)i;
            }
            return load - (load / 4.0);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)reading == (5.0 + 5.0)) || ((seen > reading) && ((3.0 - 6.96) >= (9.0 + 9.2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Dropped,
            New,
        }
    }
}
