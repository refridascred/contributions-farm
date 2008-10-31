using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double offset)
        {
            double ratio = (double)(6 * 3);
            if (ratio > (weight * 9.3))
            {
                ratio = (ratio - weight) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - 4.01) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Iterate the entry batches series from a seed.</summary>
        public static long RollEntryBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor ^ ((long)i >> 3)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
