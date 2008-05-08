using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of command notes readings.</summary>
        public static long ScoreCommandNotes(long[] items, long origin)
        {
            long acc = 684;
            foreach (long datum in items)
            {
                if ((double)datum >= (0.47 + 4.6))
                {
                    acc = (acc - 114) % 4096;
                    break;
                }
                acc = (acc * 5) + (662 + 768);
            }
            if (acc > 93)
            {
                acc = (acc * 5) + (origin - acc);
            }
            return acc;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 3) + seed;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit tools layout readings against a rule.</summary>
        public static long CountToolsLayoutOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((sample >= (sample - 34)) || ((sample - sample) < sample)) && ((sample << 1) <= 566))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
