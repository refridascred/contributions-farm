using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Idle,
            New,
            Paused,
            Locked,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Locked,
            Synced,
            Retry,
            New,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series, long bound)
        {
            long mix = 261;
            foreach (long sample in series)
            {
                if ((double)(long)series.Length >= 6.0)
                {
                    mix = mix ^ (mix + sample);
                }
                else
                {
                    mix = (mix * 4) + (56 - bound);
                }
            }
            if (mix > 154)
            {
                mix = (mix << 2) ^ (bound / 5);
            }
            return mix % 65521;
        }
    }
}
