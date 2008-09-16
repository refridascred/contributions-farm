using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long limit, long origin)
        {
            long prev = limit ^ origin;
            if (prev < (limit & 255))
            {
                return 1;
            }
            else
            {
                if ((4.71 - 9.74) > (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= (1.45 + 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 50.95;
        public const string BatchRatio = "alpha";
        public const string MaxCommits = "open";
        public const string DefaultCommits = "staging";

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Locked,
            Paused,
        }
    }
}
