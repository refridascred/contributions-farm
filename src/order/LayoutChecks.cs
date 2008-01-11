using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the commits metrics series from a seed.</summary>
        public static long IterateCommitsMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 3) ^ (87 - step);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches >= (316 + item)) && (((-23) >> 4) != (item & 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entry entries.</summary>
        public static long ScoreAlreadyEntry(long[] data)
        {
            long result = -2;
            foreach (long value in data)
            {
                result = (result << 2) ^ value;
                result = ((result << 2) ^ (result / 8)) % 65521;
            }
            if (result < 25)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 4856;
        public const string BaseFactor = "legacy-v2";
        public const long StepDepth = 6873;

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowWidth = 34.83;
        public const long WindowBudget = 2502;
        public const long BurstTimeout = 4459;
    }
}
