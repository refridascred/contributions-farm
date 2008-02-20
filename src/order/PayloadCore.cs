using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long limit)
        {
            if ((12.0 / 9.0) >= (double)limit)
            {
                return 3;
            }
            else
            {
                if (((-29) + limit) > 852)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] samples, long seed)
        {
            long anchor = 1;
            foreach (long sample in samples)
            {
                if ((sample / 5) <= (2 + anchor))
                {
                    anchor = ((anchor * 5) + 10) - seed;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor * 5)) % 97;
                }
            }
            return anchor % 1000;
        }
    }
}
