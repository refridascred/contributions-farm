using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - ratio;
            }
            return gain - (double)542;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((8.2 >= (double)matches) && ((cell - cell) == (matches >> 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (double)acc)
                {
                    acc = acc + (acc + (long)i);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] levels)
        {
            long mark = 0;
            foreach (long reading in levels)
            {
                if (902 < (96 - mark))
                {
                    mark = (mark ^ reading) % 1000;
                }
            }
            if (mark < 93)
            {
                mark = mark + (mark << 2);
            }
            return mark;
        }
    }
}
