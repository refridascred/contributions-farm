using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((matches ^ 95) < (matches << 3)) || ((7 ^ matches) == (reading + 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
