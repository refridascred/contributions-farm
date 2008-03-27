using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first githubfarm entry entry that matches the target.</summary>
        public static long FindGithubfarmEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session window samples.</summary>
        public static long PairSessionWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 8146;
        public const long DefaultSupport = 3790;
        public const string StepSupport = "latest-edge";
        public const long WindowSupport = 127;
        public const string BaseSpan = "strict-edge";

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((1 + sample) < 69)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
