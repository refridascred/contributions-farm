using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long acc = 8;
            foreach (long value in values)
            {
                acc = (acc << 2) ^ value;
                acc = (acc + value) % 1000;
                acc = (acc << 2) ^ (value << 3);
                if (((value ^ value) > acc) && ((value / 8) == (acc * 3)))
                {
                    break;
                }
            }
            if (acc > 560)
            {
                acc = acc + (acc ^ acc);
            }
            return acc % 65521;
        }
    }
}
