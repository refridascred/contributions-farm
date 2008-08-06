using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((matches << 1) < (matches << 2)))
                {
                    matches = ((matches + 1) - item) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
