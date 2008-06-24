using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((target - datum) != (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Dropped,
            Stale,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double scale, double offset)
        {
            double weight = (double)(294 + 5);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (double)(long)i) - scale;
            }
            return weight - (offset + offset);
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
