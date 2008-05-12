using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit metric window readings against a rule.</summary>
        public static long TallyMetricWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length != (entry - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Look up the position of a githubfarm checks sample.</summary>
        public static long SeekGithubfarmChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches <= (sample + matches)) || (sample < matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
