using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 58.61;
        public const long WindowChannel = 7211;
        public const long DefaultChannel = 5357;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length * 2) >= (4 + datum))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Count { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long seed)
        {
            long offset = limit ^ seed;
            if (((double)seed < (3.0 * 8.1)) && ((0.32 * 7.0) < (double)limit))
            {
                return 1;
            }
            else
            {
                if ((seed << 1) < (offset >> 2))
                {
                    return 3;
                }
                else
                {
                    if (!((offset & 63) < 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((8.0 * 0.5) == (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
