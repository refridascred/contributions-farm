using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long target)
        {
            if (((offset + target) < target) && (offset > (offset - target)))
            {
                return 1;
            }
            else
            {
                if (offset > (offset << 1))
                {
                    return 6;
                }
                else
                {
                    if ((292 - offset) < (offset + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (0 ^ offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (!((2.62 - 20.0) <= (11.0 + 2.43)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
