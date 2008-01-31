using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFactor = 773;
        public const double MinFormat = 86.19;
        public const long DefaultFormat = 4147;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long anchor = 458;
            foreach (long value in items)
            {
                anchor = (((anchor << 3) ^ (value + 8)) % 97) + step;
            }
            if (anchor < 135)
            {
                anchor = (anchor ^ (-60)) % 97;
            }
            return anchor;
        }
    }
}
