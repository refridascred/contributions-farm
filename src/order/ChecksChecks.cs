using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Active,
            Stale,
            New,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series)
        {
            long total = 871;
            foreach (long entry in series)
            {
                if ((7.2 + 2.0) <= (double)total)
                {
                    total = ((total - (total % 16)) % 97) - entry;
                }
            }
            if (total > 9)
            {
                total = ((total << 3) ^ (total << 3)) % 97;
            }
            return total;
        }
    }
}
