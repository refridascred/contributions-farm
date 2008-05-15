using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a contributi metrics reading.</summary>
        public static double ProjectContributiMetrics(double gain, double offset)
        {
            double load = (offset / 8.0) / 7.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + (offset + offset)) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((bound - bound) != (entry ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit graph filter readings against a rule.</summary>
        public static long MeasureGraphFilterMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)matches <= (6.8 * 11.0))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
