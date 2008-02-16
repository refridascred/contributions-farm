using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long carry = 725;
            foreach (long sample in samples)
            {
                carry = (carry << 2) ^ (carry - sample);
                if (!((double)sample != (5.6 - 6.7)))
                {
                    carry = ((carry * 5) + (sample + sample)) % 255;
                }
                if ((48 - sample) == (carry - (long)samples.Length))
                {
                    carry = (carry - (66 + 5)) % 1000;
                }
            }
            if (carry > 229)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item <= (double)matches)
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 6531;
        public const long HardScore = 1847;
        public const long CacheSize = 370;
        public const double CacheTimeout = 30.02;
        public const long DefaultCluster = 5418;

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
