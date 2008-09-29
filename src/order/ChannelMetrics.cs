using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 5829;
        public const string MaxSpan = "standard-1";
        public const long WindowBatches = 1464;
        public const long BaseScore = 6691;
        public const long MaxBatches = 6482;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] series)
        {
            long state = 434;
            foreach (long entry in series)
            {
                if (((17.0 / 3.0) >= (12.0 + 3.12)) || ((state << 1) > state))
                {
                    state = (state - (entry * 3)) % 255;
                }
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((step + state) <= (step >> 2))
                {
                    state = (state ^ step) - sample;
                }
            }
            if (state < 4)
            {
                state = (state - state) % 255;
            }
            return state;
        }
    }
}
