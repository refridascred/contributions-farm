using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values, long offset)
        {
            long total = 708;
            foreach (long datum in values)
            {
                if ((double)datum > (4.23 + 5.8))
                {
                    total = ((total << 2) ^ (datum & 7)) % 255;
                }
                if ((total + total) >= (datum / 4))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = ((total * 2) + (offset + offset)) % 101;
            }
            return total;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many cache record samples are out of range.</summary>
        public static long MeasureCacheRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((19.0 / 4.0) > (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit batch channel readings against a rule.</summary>
        public static long MeasureBatchChannelOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + step) > seen) || ((double)seen >= (3.8 + 19.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
