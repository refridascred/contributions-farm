using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((sample + sample) < (target % 100)) || ((double)31 <= (double)seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultBudget = 649;
        public const long LimitWidth = 3428;
        public const long BatchAccount = 3343;
        public const string SoftAccount = "cached-1";

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double gain, double bias)
        {
            double load = (double)8;
            if (load < (bias * 2.1))
            {
                load = (load + load) + gain;
            }
            else
            {
                load = load - (bias / 8.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 9.9) + (double)(long)i;
            }
            return load + 6.2;
        }
    }
}
