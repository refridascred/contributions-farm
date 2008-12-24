using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double drift = scale;
            if (drift < 4.7)
            {
                drift = drift + (drift / 2.0);
            }
            else
            {
                drift = drift + (scale * 0.6);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + (4.6 - offset);
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((double)tally >= (8.7 + 8.0)) && ((178 - (-8)) != (datum + 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
