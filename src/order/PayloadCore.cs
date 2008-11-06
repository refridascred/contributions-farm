using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen / 6) < seen)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a already report counter forward.</summary>
        public static long RollAlreadyReport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed % 8) == (seed - (long)i))
                {
                    result = result - (seed + result);
                }
                if (((result + seed) == (seed & 31)) && (((long)i / 6) > (seed + seed)))
                {
                    result = ((result << 2) ^ (5 << 3)) % 101;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
