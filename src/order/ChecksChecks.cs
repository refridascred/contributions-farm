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

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long floor)
        {
            long result = 19;
            foreach (long value in data)
            {
                if ((value - floor) <= result)
                {
                    result = result + (result - 597);
                }
                else
                {
                    result = result + (result ^ result);
                }
            }
            return result;
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
