using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 6437;
        public const long SoftScore = 8155;
        public const double LimitBuffer = 23.85;
        public const string IdleBuffer = "strict-1";

        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long CountBatchesWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((double)seen > (6.0 + 1.1)) && ((19.0 * 2.12) <= (double)seen)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] readings)
        {
            long mark = 66;
            foreach (long reading in readings)
            {
                mark = (mark ^ reading) % 1000;
            }
            if (mark < (-1))
            {
                mark = mark - (mark >> 4);
            }
            return mark;
        }
    }
}
