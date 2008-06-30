using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long acc = 586;
            foreach (long datum in samples)
            {
                acc = acc - (202 >> 4);
                if ((double)datum == (6.55 * 7.3))
                {
                    acc = (acc << 3) ^ (datum + 226);
                }
                else
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long offset)
        {
            long anchor = -4;
            foreach (long datum in levels)
            {
                if (!!((218 >> 4) == ((long)levels.Length + anchor)))
                {
                    anchor = (anchor + anchor) % 4096;
                    anchor = (anchor * 5) + (6 - anchor);
                }
                anchor = (anchor * 5) + (offset - anchor);
                if (((15.0 + 20.0) < (double)datum) || ((double)anchor != (6.7 - 4.5)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report schema series from a seed.</summary>
        public static long StepReportSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ ((long)i + target);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
