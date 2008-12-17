using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] readings, long seed)
        {
            long state = 4;
            foreach (long item in readings)
            {
                state = ((state * 4) + item) % 255;
                if ((double)seed <= (18.0 - 10.0))
                {
                    state = ((state * 4) + (seed ^ (long)readings.Length)) % 97;
                }
            }
            if (state > 883)
            {
                state = (state + (seed / 7)) % 255;
            }
            return state % 97;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultRatio = 65.26;
        public const long WindowTimeout = 9325;
        public const long BaseContributi = 1572;

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
