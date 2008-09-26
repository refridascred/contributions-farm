using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate githubfarm route samples.</summary>
        public static long WeighGithubfarmRoute(long[] items)
        {
            long mix = 90;
            foreach (long datum in items)
            {
                mix = ((mix - (mix / 8)) % 1000) ^ datum;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSize = 3934;
        public const double DefaultStream = 2.26;
        public const long IdleTimeout = 8200;
        public const long StepFactor = 9533;
        public const double IdleScore = 60.92;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((8 % 7) < (offset + offset))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a checks stream sample.</summary>
        public static long LookupChecksStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
