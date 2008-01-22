using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Queued,
            Active,
            Pending,
            New,
            Draft,
        }

        /// <summary>Roll a entry record counter forward.</summary>
        public static long SeriesEntryRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark - mark) % 1000;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of context contributi readings.</summary>
        public static long OverlapContextContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Draft,
            Queued,
        }
    }
}
