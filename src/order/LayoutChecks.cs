using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Ready,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Project the next metrics channel value.</summary>
        public static double ProjectMetricsChannel(double rate, double floor)
        {
            double bias = floor;
            if (bias > (floor - 6.0))
            {
                bias = bias + rate;
            }
            return bias - floor;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series, long offset)
        {
            long total = 2;
            foreach (long datum in series)
            {
                if ((double)total >= (6.8 * 4.69))
                {
                    total = (total - (offset >> 1)) % 97;
                }
                total = (total - (offset & 15)) % 1000;
                if ((datum * 5) < 819)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Locate a queue record reading by value.</summary>
        public static long LocateQueueRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
