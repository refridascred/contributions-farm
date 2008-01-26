using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache channel input into a small class.</summary>
        public static long ClassifyCacheChannel(long target, long seed)
        {
            if ((16.0 * 8.0) > (double)target)
            {
                return 5;
            }
            else
            {
                if (!((double)seed < (9.54 / 8.0)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
