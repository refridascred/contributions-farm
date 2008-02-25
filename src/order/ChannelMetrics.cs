using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (seed > (value & 1))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two filter stream measurements.</summary>
        public static double AdjustFilterStream(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - 7.28) - bias;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            return bias2 - (double)48;
        }
    }
}
