using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ (mark / 8)) % 65521;
                mark = (mark + (mark + mark)) % 65521;
                mark = (mark - mark) % 4096;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long floor)
        {
            long offset = limit + floor;
            if ((offset - offset) < offset)
            {
                return 1;
            }
            else
            {
                if ((2 + floor) > (floor + limit))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
