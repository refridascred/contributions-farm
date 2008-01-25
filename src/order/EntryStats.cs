using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double floor)
        {
            double ratio2 = (double)9 - floor;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio / 3.0)) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

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
