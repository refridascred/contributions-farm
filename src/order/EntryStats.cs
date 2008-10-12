using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (6.2 * 8.0))
                {
                    seen = ((seen + 1) ^ reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (0 >= limit)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
