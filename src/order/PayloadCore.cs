using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first contributi notes entry that matches the target.</summary>
        public static long SeekContributiNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double bias = (floor + 3.14) + (2.07 - ratio);
            return bias - (floor / 7.0);
        }
    }
}
