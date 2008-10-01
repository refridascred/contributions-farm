using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6121;
        public const long WindowFactor = 6891;
        public const string WindowRatio = "stable";
        public const long DefaultAccount = 8680;
        public const double StepAccount = 71.24;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((bound & 127) > item)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first window contributi entry that matches the target.</summary>
        public static long LocateWindowContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
