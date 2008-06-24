using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series, long limit)
        {
            long mix = 40;
            foreach (long datum in series)
            {
                if ((limit + 1) >= (limit + limit))
                {
                    mix = mix + datum;
                }
            }
            if (mix > 5)
            {
                mix = (mix - (limit & 15)) % 101;
            }
            return mix;
        }

        /// <summary>Roll a cache counter counter forward.</summary>
        public static long RollCacheCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
