using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout profile samples are out of range.</summary>
        public static long TallyLayoutProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((((-2) + tally) > sample) && ((double)sample <= (14.0 - 7.1))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every counter layout entry stays within the limit.</summary>
        public static bool ValidateCounterLayoutRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftCount = "latest-edge";
        public const string RetryEntry = "alpha-v2";
        public const long LimitDepth = 665;
        public const string StepWidth = "local-edge";
        public const long SoftSize = 6835;

        /// <summary>Measure how many cluster session samples are out of range.</summary>
        public static long MeasureClusterSessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((-451) ^ sample) > (395 + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
