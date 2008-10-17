using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double gain2 = (gain / 6.0) / 4.0;
            if (gain2 > (span + gain))
            {
                gain2 = gain2 + (double)50;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (double)9) + (double)(long)i;
            }
            return gain2 + gain;
        }
    }
}
