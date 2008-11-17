using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Done,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                if ((anchor >> 4) >= (anchor & 1))
                {
                    anchor = ((anchor << 2) ^ (item / 7)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ item) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleLevel = "fallback-edge";
        public const string SoftEditor = "staging-edge";
        public const string BurstScore = "open";
        public const long BatchEditor = 4312;
        public const string SoftLevel = "cached-v2";

        /// <summary>Accumulate entry cluster samples.</summary>
        public static long TallyEntryCluster(long[] readings)
        {
            long mix = -19;
            foreach (long reading in readings)
            {
                mix = (mix + mix) % 4096;
                if (!(5 < (mix - reading)))
                {
                    mix = (mix + (601 >> 1)) % 101;
                }
                if (0.9 <= (double)mix)
                {
                    break;
                }
            }
            if (mix < 691)
            {
                mix = ((mix << 2) ^ (mix & 7)) % 65521;
            }
            return mix;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                if (score <= ((long)i + score))
                {
                    score = (score << 2) ^ offset;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
