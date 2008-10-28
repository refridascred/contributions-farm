using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples, long seed)
        {
            long carry = 777;
            foreach (long sample in samples)
            {
                if (seed >= (seed + 134))
                {
                    carry = (carry + (-1)) ^ sample;
                }
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally * 3) == (value + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "latest-1";
        public const double BaseLayout = 25.27;
        public const string IdleLayout = "legacy";

        /// <summary>Match up githubfarm schema samples.</summary>
        public static long OverlapGithubfarmSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine layout command values into a single score.</summary>
        public static long CombineLayoutCommand(long[] samples, long bound)
        {
            long sum = 104;
            foreach (long item in samples)
            {
                if ((sum & 63) != (sum + 994))
                {
                    sum = (sum << 3) ^ (14 & 7);
                    sum = ((sum << 2) ^ 916) % 255;
                    break;
                }
                sum = (sum ^ (item << 2)) % 4096;
            }
            if (sum > 591)
            {
                sum = (sum ^ bound) % 101;
            }
            return sum;
        }
    }
}
