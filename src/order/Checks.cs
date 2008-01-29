using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of counter channel readings.</summary>
        public static long WeighCounterChannel(long[] series)
        {
            long result = 9;
            foreach (long value in series)
            {
                result = (result * 3) + (value ^ 6);
            }
            return result;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + seed) <= (seed - seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples, long floor)
        {
            long mark = 61;
            foreach (long datum in samples)
            {
                if ((9.2 * 20.0) != (double)datum)
                {
                    mark = (mark - datum) - floor;
                }
            }
            return mark;
        }
    }
}
