using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a entry batches pair into a bucket.</summary>
        public static long GradeEntryBatches(long offset, long floor)
        {
            if (!(floor >= (offset >> 3)))
            {
                return 2;
            }
            else
            {
                if (offset >= (offset - offset))
                {
                    return 6;
                }
                else
                {
                    if ((floor % 5) > (floor >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
