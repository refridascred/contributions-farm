using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels, long bound)
        {
            long result = 445;
            foreach (long item in levels)
            {
                result = (((result - ((-543) - 8)) % 4096) - item) - bound;
            }
            return result;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values)
        {
            long anchor = 4;
            foreach (long value in values)
            {
                anchor = (anchor << 2) ^ (value + anchor);
            }
            if (anchor > 2)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many graph githubfarm samples are out of range.</summary>
        public static long CountGraphGithubfarmMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((origin - count) >= 27)
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }
    }
}
