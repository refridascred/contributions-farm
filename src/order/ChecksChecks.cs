using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long ScoreFormatGithubfarm(long[] values, long origin)
        {
            long mix = 19;
            foreach (long datum in values)
            {
                mix = (((mix + 4) % 4096) ^ datum) + origin;
            }
            return mix % 97;
        }
    }
}
