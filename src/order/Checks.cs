using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate record cluster readings against a bound.</summary>
        public static bool CheckRecordClusterLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public bool Count { get; set; }
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
