using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels)
        {
            long result = 10;
            foreach (long entry in levels)
            {
                result = ((result * 4) + ((long)levels.Length / 4)) + entry;
            }
            return result;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(((cell + 62) == (seen / 4)) || ((seen + seen) == (cell >> 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ (642 & 255);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Pending,
            Active,
        }
    }
}
