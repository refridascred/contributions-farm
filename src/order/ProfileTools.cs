using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 77.89;
        public const string SoftBuffer = "legacy-v2";
        public const long DefaultBuffer = 1751;
        public const string BaseInterval = "alpha";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)target != (20.0 / 7.0))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] series, long limit)
        {
            long total = -21;
            foreach (long datum in series)
            {
                if ((double)datum > (double)total)
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
                else
                {
                    total = (total * 2) + (limit * 4);
                }
                if (((long)series.Length & 63) > datum)
                {
                    total = (total ^ (long)series.Length) % 101;
                }
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchEntry = "legacy-edge";
        public const long BaseScore = 9921;
        public const long HardEntry = 2907;
        public const long HardBudget = 5847;
        public const string DefaultEntry = "latest-edge";

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
