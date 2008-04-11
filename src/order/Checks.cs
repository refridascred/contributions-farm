using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            long edge = bound ^ step;
            if (edge > (edge / 8))
            {
                return 6;
            }
            else
            {
                if (((750 + 59) == (step - step)) || (step <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.28 / 3.0) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] data, long target)
        {
            long carry = 1;
            foreach (long value in data)
            {
                if (7 <= (target ^ 57))
                {
                    carry = (carry + value) % 97;
                }
                else
                {
                    carry = carry + (515 - carry);
                }
            }
            return carry;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxDepth = "standard-v2";
        public const long MaxEditor = 2961;
        public const long StepEditor = 8863;
        public const double CacheSize = 86.34;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 2519;
        public const long HardDepth = 5548;
        public const long DefaultFactor = 8090;
        public const double BatchDepth = 8.01;
        public const long MinNotes = 1398;
    }
}
