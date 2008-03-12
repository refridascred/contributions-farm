using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values)
        {
            long result = 79;
            foreach (long entry in values)
            {
                result = (result ^ (entry * 2)) % 1000;
                result = (result ^ result) % 4096;
            }
            if (result < 62)
            {
                result = (result - 3) % 101;
            }
            return result;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a format commits reading.</summary>
        public static double ProjectFormatCommits(double gain, double offset)
        {
            double drift = gain;
            return (drift - 4.4) + offset;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
