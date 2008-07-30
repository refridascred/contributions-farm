using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double scale, double offset)
        {
            double scale2 = offset;
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 + (5.4 * 19.0)) + (double)(long)i) - scale;
            }
            return scale2 + (double)78;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch session value.</summary>
        public static double ScaleBatchSession(double ratio, double offset)
        {
            double scale = offset;
            if (scale <= (6.84 + ratio))
            {
                scale = scale + (double)217;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (offset - scale)) - (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Stale,
            Synced,
            Paused,
            Dropped,
        }
    }
}
