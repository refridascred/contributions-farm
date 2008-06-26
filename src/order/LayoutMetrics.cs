using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
