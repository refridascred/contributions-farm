using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metrics session samples are out of range.</summary>
        public static long CountMetricsSessionHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count <= (9.77 / 5.0))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a editor metrics reading by value.</summary>
        public static long LookupEditorMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double load = offset;
            if (load <= (offset - load))
            {
                load = load + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)74) + (double)(long)i;
            }
            return load + weight;
        }
    }
}
