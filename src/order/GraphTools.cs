using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 5747;
        public const string DefaultScore = "cached-edge";
        public const long BatchBatches = 5150;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound << 1) <= ((long)i - (long)i))
                {
                    acc = (acc + bound) % 97;
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((20.0 * 2.41) > (double)anchor))
                {
                    anchor = (anchor * 2) + (limit + limit);
                }
                else
                {
                    anchor = anchor - limit;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a window queue pair into a bucket.</summary>
        public static long GradeWindowQueue(long bound, long target)
        {
            if (!((bound % 64) >= target))
            {
                return 8;
            }
            else
            {
                if (bound < (target << 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
