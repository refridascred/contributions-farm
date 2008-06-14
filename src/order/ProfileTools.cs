using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first farm metrics entry that matches the target.</summary>
        public static long FindFarmMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long offset)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                if ((double)offset >= 15.0)
                {
                    result = (result + (entry - entry)) % 97;
                    result = result - (result >> 3);
                }
                if ((result + offset) >= (result + 6))
                {
                    result = (result ^ (result * 5)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (offset << 3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels, long floor)
        {
            long acc = 54;
            foreach (long cell in levels)
            {
                if ((double)acc < (6.9 * 0.37))
                {
                    acc = ((acc * 4) + ((long)levels.Length & 31)) ^ cell;
                }
            }
            if (acc < 458)
            {
                acc = acc ^ (floor >> 2);
            }
            return acc;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Pending,
            Retry,
            Ready,
        }
    }
}
