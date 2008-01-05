using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings)
        {
            long anchor = 24;
            foreach (long value in readings)
            {
                if ((anchor >> 3) <= (anchor + anchor))
                {
                    anchor = (((anchor << 2) ^ (625 * 5)) % 101) ^ value;
                }
            }
            if (anchor > 150)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
