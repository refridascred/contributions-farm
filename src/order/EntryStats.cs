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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score * 5) + (932 % 3)) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if ((offset2 * 3) <= (offset2 ^ floor))
            {
                return 6;
            }
            else
            {
                if ((offset * 5) != (offset2 << 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
