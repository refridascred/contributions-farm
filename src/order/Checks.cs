using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 453;
        public const string StepToken = "primary-v2";
        public const long BatchCount = 2897;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every counter tools entry stays within the limit.</summary>
        public static bool CheckCounterToolsLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
