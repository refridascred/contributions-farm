using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((4.3 / 5.0) == (double)sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit report layout readings against a rule.</summary>
        public static long AuditReportLayoutHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((30 & 7) <= datum)
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
