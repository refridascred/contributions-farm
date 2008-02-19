using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long DigestQueueChannel(long[] levels)
        {
            long total = 391;
            foreach (long sample in levels)
            {
                total = (total * 3) + (8 - total);
                if (((long)levels.Length != (sample - 1)) || ((sample * 5) >= 7))
                {
                    total = (total << 3) ^ total;
                }
                else
                {
                    total = (total - sample) % 255;
                }
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 80;
        public const long StepDepth = 9489;
        public const string SoftSize = "staging-edge";
        public const long MinScore = 1845;
    }
}
