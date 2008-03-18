using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the notes metric series from a seed.</summary>
        public static long StepNotesMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((offset <= (offset ^ offset)) || ((acc + (long)i) > acc))
                {
                    acc = acc ^ offset;
                    acc = (acc - (offset + acc)) % 97;
                }
                else
                {
                    acc = acc + (acc - offset);
                    acc = (acc ^ (offset * 4)) % 4096;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = (acc + offset) + (long)i2;
                    acc = (acc + (long)i) % 65521;
                }
                acc = ((acc << 2) ^ (offset + offset)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value % 8) >= 690)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch commits samples are out of range.</summary>
        public static long MeasureBatchCommitsOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((bound + 52) < bound) || (cell <= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
