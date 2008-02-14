using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double span)
        {
            double mean = 0.64;
            return (mean - (span - 2.2)) + ratio;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series)
        {
            long anchor = 2;
            foreach (long entry in series)
            {
                if ((entry % 10) != (835 & 127))
                {
                    anchor = (anchor * 5) + (entry - entry);
                }
                if ((8.0 / 9.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
