using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - 9) < count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long offset, long offset2)
        {
            if ((double)offset2 != (0.86 - 6.7))
            {
                return 0;
            }
            else
            {
                if (((0 << 2) > (offset * 2)) || ((4 >> 2) < offset))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
