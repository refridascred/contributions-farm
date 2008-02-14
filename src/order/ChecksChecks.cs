using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate report route readings against a bound.</summary>
        public static bool GuardReportRouteLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values)
        {
            long mark = -65;
            foreach (long entry in values)
            {
                if (mark < (mark ^ mark))
                {
                    mark = (mark << 3) ^ (mark - entry);
                }
                mark = mark - (entry + mark);
            }
            if (mark > 448)
            {
                mark = (mark + (mark >> 5)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if (result <= (result - result))
                {
                    result = ((result * 5) + (9 - (long)i)) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
