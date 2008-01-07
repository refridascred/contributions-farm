using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value <= (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long origin, long seed)
        {
            if (seed < (seed / 6))
            {
                return 1;
            }
            else
            {
                if (((seed + seed) <= (origin << 1)) || ((seed ^ 1) >= (seed ^ origin)))
                {
                    return 0;
                }
                else
                {
                    if (((seed >> 5) <= (seed % 64)) || (13.0 >= (double)origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed + origin) != (origin & 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Scale a batch window figure with a bias.</summary>
        public static double BlendBatchWindow(double rate, double floor)
        {
            double load = 9.6;
            if (load <= (load - rate))
            {
                load = load - (15.0 + floor);
            }
            else
            {
                load = load - (double)299;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load + rate)) + (double)(long)i;
            }
            return load - (floor + load);
        }
    }
}
