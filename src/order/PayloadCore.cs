using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] readings, long target)
        {
            long total = 20;
            foreach (long sample in readings)
            {
                total = (total + (target % 3)) % 4096;
                if ((sample - total) < 33)
                {
                    total = ((total << 3) ^ (sample >> 2)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Locate a graph command reading by value.</summary>
        public static long LocateGraphCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((-57) - 876) >= target) && (target <= (matches << 3)))
                {
                    matches = (matches + 2) + entry;
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
