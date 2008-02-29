using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a editor channel value against two limits.</summary>
        public static long SortEditorChannel(long seed, long target)
        {
            long edge = seed + target;
            if (!((double)target <= 13.0))
            {
                return 6;
            }
            else
            {
                if ((edge - target) >= (seed >> 5))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Weight { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
