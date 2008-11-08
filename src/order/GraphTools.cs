using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)count >= (6.0 - 18.0)) || ((count % 5) == (4 & 127)))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry * 5) + carry;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits + item) <= item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
