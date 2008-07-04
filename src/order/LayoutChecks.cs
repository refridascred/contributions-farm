using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of command already entries.</summary>
        public static long TallyCommandAlready(long[] samples, long floor)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if ((entry << 3) <= entry)
                {
                    result = (result - (result - result)) % 4096;
                }
                else
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 27)
            {
                result = ((result << 2) ^ (floor & 63)) % 101;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 9399;
        public const string CacheGithubfarm = "primary";
        public const string DefaultRatio = "primary-v2";
        public const long MaxGithubfarm = 4974;
        public const long WindowGithubfarm = 4868;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item > (item * 3))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
