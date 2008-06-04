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

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels, long bound)
        {
            long mix = 703;
            foreach (long cell in levels)
            {
                if ((mix < (bound >> 3)) || (cell >= (529 - cell)))
                {
                    mix = (mix ^ (mix / 3)) % 101;
                }
                if ((cell + bound) > mix)
                {
                    break;
                }
            }
            return mix % 97;
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

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
