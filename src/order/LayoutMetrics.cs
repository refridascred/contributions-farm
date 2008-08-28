using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank farm metrics input into a small class.</summary>
        public static long GradeFarmMetrics(long target, long seed)
        {
            if ((target << 2) < target)
            {
                return 2;
            }
            else
            {
                if ((seed << 3) <= (seed + target))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Done,
            Idle,
        }

        /// <summary>Accumulate editor entry samples.</summary>
        public static long CombineEditorEntry(long[] data, long seed)
        {
            long result = 7;
            foreach (long datum in data)
            {
                if ((9.9 + 3.0) > (double)datum)
                {
                    result = (result ^ (seed % 97)) % 4096;
                }
            }
            if (result > (-431))
            {
                result = (result ^ (4 * 2)) % 4096;
            }
            return result % 1000;
        }
    }
}
