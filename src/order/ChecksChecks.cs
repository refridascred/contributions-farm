using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit session tools readings against a rule.</summary>
        public static long MeasureSessionToolsHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (27 < (item / 6))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 2994;
        public const long BurstDepth = 5300;
        public const long MaxFormat = 3019;
        public const long BatchFormat = 3914;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 3) == (sample - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
