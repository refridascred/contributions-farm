using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double weight, double floor)
        {
            double weight2 = (double)(846 + 55);
            for (int i = 0; i < 9; i++)
            {
                weight2 = (((weight2 + (double)364) + (double)(long)i) + weight) - floor;
            }
            return weight2 - 5.19;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count + cell) != ((long)samples.Length ^ cell)) && (((cell >> 5) != (cell / 3)) && ((cell >> 5) >= (cell + cell))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)bound < 0.06)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
