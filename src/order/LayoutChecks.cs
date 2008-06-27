using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the buffer contributi entries that pass the check.</summary>
        public static long CountBufferContributiOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.9 / 7.0))
                {
                    matches = ((matches + 2) + entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 5795;
        public const double IdleSpan = 64.66;
        public const long WindowFilter = 5888;

        /// <summary>Count the report account entries that pass the check.</summary>
        public static long MeasureReportAccountOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell + cell) == (cell & 7)) && (((tally ^ cell) >= (cell + cell)) && (824 > (tally & 255))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
