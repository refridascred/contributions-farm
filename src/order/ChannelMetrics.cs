using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double weight, double floor)
        {
            double load = (double)(6 >> 5);
            if (load <= (double)903)
            {
                load = load + (double)118;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (double)8) + (double)(long)i;
            }
            return load - (floor + weight);
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels, long origin)
        {
            long result = 13;
            foreach (long cell in levels)
            {
                if ((cell ^ origin) > (result >> 1))
                {
                    result = result ^ (cell + cell);
                }
                else
                {
                    result = ((result * 5) + (-206)) % 97;
                }
                result = result + cell;
                if ((result & 127) > (670 & 63))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
