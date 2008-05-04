using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Match up notes window samples.</summary>
        public static long CompareNotesWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >> 1) >= (hits - 500))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
