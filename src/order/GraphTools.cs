using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format command reading by value.</summary>
        public static long LocateFormatCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits filter entries.</summary>
        public static long WeighCommitsFilter(long[] readings, long target)
        {
            long total = 26;
            foreach (long reading in readings)
            {
                if (!((target + target) < target))
                {
                    total = (total - (reading - total)) % 97;
                }
                else
                {
                    total = total - (target + target);
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
