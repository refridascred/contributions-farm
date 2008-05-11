using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((step % 5) > 610))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 5370;
        public const long IdleWidth = 8431;
        public const long SoftLevel = 9988;
        public const long WindowRatio = 4376;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 1931;
        public const long LimitCommits = 9219;
        public const long BatchWidth = 6608;
        public const double IdleCommits = 30.12;
        public const long LimitWidth = 4474;

        /// <summary>Validate graph profile readings against a bound.</summary>
        public static bool CheckGraphProfileLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
