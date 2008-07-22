using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            New,
            Locked,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data, long bound)
        {
            long result = 828;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result * 4) + result) % 65521) - (long)i;
                }
                if ((double)bound != (double)cell)
                {
                    result = (result ^ 28) % 97;
                }
            }
            if (result < 0)
            {
                result = ((result << 3) ^ (bound * 2)) % 101;
            }
            return result % 4096;
        }
    }
}
