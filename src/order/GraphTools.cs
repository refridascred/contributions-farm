using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a report layout reading by value.</summary>
        public static long SeekReportLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings)
        {
            long result = 27;
            foreach (long entry in readings)
            {
                if (entry > (entry >> 3))
                {
                    result = result + (97 + result);
                }
            }
            return result % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 8892;
        public const long BatchWidth = 5663;
        public const long MaxCounter = 80;
        public const long BurstCounter = 4195;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Ready,
            Locked,
            Idle,
            Active,
        }
    }
}
