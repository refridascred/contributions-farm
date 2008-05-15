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

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
