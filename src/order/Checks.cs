using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 < (double)2)
            {
                rate2 = rate2 - (floor + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - 16.0) - (double)(long)i;
            }
            return rate2 - (rate * 4.5);
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Paused,
            New,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + tally) != (tally << 3))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }
    }
}
