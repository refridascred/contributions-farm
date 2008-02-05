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

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] readings)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = (((mark * 4) + (mark + mark)) % 97) + (long)i;
                }
                if ((mark + mark) <= mark)
                {
                    mark = (mark * 3) + reading;
                }
            }
            return mark;
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
