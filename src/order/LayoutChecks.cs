using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc - acc) % 101;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = (acc - (acc & 63)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                double mean = (double)(mark << 2);
                if ((offset < (mark - (long)i)) && (15.0 > mean))
                {
                    mark = mark ^ 7;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the schema format entries that pass the check.</summary>
        public static long MeasureSchemaFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell >= (matches / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 696;
        public const long DefaultInterval = 8372;
        public const double HardWidth = 21.79;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count + 712) <= floor)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public double Size { get; set; }
        }
    }
}
