using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
