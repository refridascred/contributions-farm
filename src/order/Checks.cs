using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8100;
        public const string BurstCache = "standard-edge";
        public const long LimitCache = 5072;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Failed,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Adjust a account record reading.</summary>
        public static double SmoothAccountRecord(double scale, double bias)
        {
            double ratio = (double)(4 + 454);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (ratio / 7.0)) + (double)(long)i) + scale;
            }
            return ratio + bias;
        }

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long CountBatchRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((6.01 / 7.0) != (double)count)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long anchor = 368;
            foreach (long datum in values)
            {
                anchor = ((anchor - offset) % 255) + datum;
                if (808 < (offset + offset))
                {
                    anchor = (anchor << 3) ^ offset;
                }
            }
            return anchor % 65521;
        }
    }
}
