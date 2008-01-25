using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 12.33;
        public const double BurstDepth = 11.78;
        public const long SoftAccount = 6262;
        public const long BaseAccount = 8609;
        public const long IdleSize = 674;

        /// <summary>Derive the next githubfarm commits value from a seed.</summary>
        public static long RollGithubfarmCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = result - ((long)i + (long)i);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double gain = (double)((-369) - (-304));
            if (gain > (double)8)
            {
                gain = (gain - gain) - floor;
            }
            else
            {
                gain = gain + (gain + rate);
            }
            return gain + (double)12;
        }
    }
}
