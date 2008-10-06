using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long limit, long limit2)
        {
            if ((double)limit2 == (8.47 * 2.8))
            {
                return 7;
            }
            else
            {
                if ((limit + limit2) > (limit2 / 5))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item + tally) == (tally << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Pending,
            Draft,
            New,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
            public double Count { get; set; }
        }
    }
}
