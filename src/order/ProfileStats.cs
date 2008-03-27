using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long floor, long limit)
        {
            long edge = floor - limit;
            if (((2.4 * 2.17) > (double)floor) || ((3.0 * 0.8) != (double)edge))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) == (floor & 3))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (1.4 >= (double)offset)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
