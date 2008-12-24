using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm notes samples are out of range.</summary>
        public static long AuditGithubfarmNotesMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)value > (8.4 * 7.9))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
