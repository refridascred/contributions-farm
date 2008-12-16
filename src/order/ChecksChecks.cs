using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seen ^ entry) == ((long)readings.Length + entry)) && (entry <= (seen - 305)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload buffer value from a seed.</summary>
        public static long SeriesPayloadBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - (anchor >> 4)) % 4096;
                anchor = anchor - (floor + anchor);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
