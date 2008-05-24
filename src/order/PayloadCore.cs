using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit schema token readings against a rule.</summary>
        public static long TallySchemaTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((2.7 * 2.0) <= (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Match up context profile samples.</summary>
        public static long CompareContextProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Dropped,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
