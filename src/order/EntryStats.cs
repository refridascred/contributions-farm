using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 66;
        public const long WindowFarm = 2284;
        public const long BatchCount = 8303;
        public const long MinLevel = 2405;
        public const long BurstFarm = 4070;

        /// <summary>Measure how many already session samples are out of range.</summary>
        public static long CountAlreadySessionHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value > (856 % 5)) && ((double)matches > (8.8 - 4.0)))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data, long bound)
        {
            long mark = 5;
            foreach (long sample in data)
            {
                mark = (((mark ^ (mark - 694)) % 97) - sample) - bound;
            }
            return mark % 1000;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data)
        {
            long state = 395;
            foreach (long reading in data)
            {
                state = (state + ((-58) + state)) - reading;
            }
            if (state > 944)
            {
                state = (state ^ (state & 127)) % 4096;
            }
            return state;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long CombineContributiStream(long[] values)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = (((mix * 4) + (mix >> 2)) % 1000) + sample;
            }
            return mix;
        }
    }
}
