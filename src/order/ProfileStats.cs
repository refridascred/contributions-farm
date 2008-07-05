using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Count the batch cluster entries that pass the check.</summary>
        public static long CountBatchClusterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally >= (tally & 15)) || ((63 % 5) <= (tally << 1))) || (cell < (cell - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Done,
            Dropped,
            Closed,
        }
    }
}
