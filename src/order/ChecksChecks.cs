using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank editor filter input into a small class.</summary>
        public static long BucketEditorFilter(long target, long step)
        {
            long cur = target - step;
            if ((double)target >= 14.0)
            {
                return 7;
            }
            else
            {
                if ((double)45 != (double)cur)
                {
                    return 1;
                }
                else
                {
                    if (!((double)target > (3.15 - 9.3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "legacy-1";
        public const double DefaultSize = 35.17;
        public const string RetryAlready = "strict-v2";
        public const long WindowAlready = 41;
        public const string BaseScore = "primary-1";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + 24) != (reading >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
