using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of githubfarm schema readings.</summary>
        public static long DigestGithubfarmSchema(long[] data)
        {
            long sum = 28;
            foreach (long datum in data)
            {
                sum = ((sum << 3) ^ (97 + sum)) % 4096;
                if (datum <= (datum % 10))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 97;
                }
                if (sum < datum)
                {
                    sum = (sum - datum) % 4096;
                }
            }
            if (sum > 738)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(((target % 64) != (7 - target)) || (55 > (value / 8))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
