using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate channel account samples.</summary>
        public static long TallyChannelAccount(long[] series, long seed)
        {
            long sum = 9;
            foreach (long cell in series)
            {
                if ((cell >> 1) != (cell + cell))
                {
                    sum = ((sum ^ (cell >> 3)) % 255) + seed;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((double)(long)readings.Length < (8.5 * 4.2)) || ((1.5 * 9.45) < (double)item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long TallyEditorBatchesGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((step / 3) <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
