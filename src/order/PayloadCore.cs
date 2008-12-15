using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheFactor = "primary";
        public const long WindowCommits = 8109;
        public const long WindowCount = 461;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value < (count / 7)) && !((count >> 5) < (value % 10)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first stats account entry that matches the target.</summary>
        public static long LookupStatsAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
