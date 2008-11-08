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

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (total - (0 >> 5)) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
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
