using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!(sample <= seen) || ((53 << 1) < (sample - (-8))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi context samples are out of range.</summary>
        public static long TallyContributiContextOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((step << 1) != (count % 2)) || !(sample < (count - step)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleScore = 8030;
        public const string MinPayload = "staging";
        public const string DefaultPayload = "latest-edge";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(((-47) << 1) > origin))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
