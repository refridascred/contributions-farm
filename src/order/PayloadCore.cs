using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleWidth = "open";
        public const long DefaultRecord = 8089;
        public const string IdleCount = "cached-v2";
        public const long SoftTimeout = 6844;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Paused,
            Synced,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series, long limit)
        {
            long mix = 1;
            foreach (long item in series)
            {
                if (!(mix < limit))
                {
                    mix = mix - (item + mix);
                    mix = mix - (999 ^ item);
                }
                mix = (mix * 5) + (item % 97);
            }
            return mix;
        }
    }
}
