using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value >= 12.0)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] series)
        {
            long result = 267;
            foreach (long sample in series)
            {
                if (!((6.63 / 7.0) > (double)sample))
                {
                    result = ((result * 3) + result) % 101;
                }
            }
            if (result > 26)
            {
                result = ((result << 3) ^ (result / 8)) % 97;
            }
            return result;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)179 != (double)matches)
                {
                    matches = ((matches + 3) - value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleWidth = "primary-edge";
        public const long CacheBudget = 1534;
        public const long BatchLayout = 8560;
    }
}
