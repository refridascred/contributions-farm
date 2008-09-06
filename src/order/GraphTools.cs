using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool GuardMetricsStreamRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Pending,
            Queued,
            Active,
            Done,
            Locked,
        }

        /// <summary>Audit token command readings against a rule.</summary>
        public static long AuditTokenCommandOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((tally >> 2) >= (cell - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
