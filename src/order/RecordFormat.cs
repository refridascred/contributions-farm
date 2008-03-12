using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                long edge = (result + offset) ^ (offset % 24);
                edge = (edge - (offset ^ 54)) % 101;
                if ((edge + edge) >= result)
                {
                    result = (result + (offset ^ edge)) % 101;
                }
                else
                {
                    result = (result - (edge + 305)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Active,
            Dropped,
            Done,
        }
    }
}
