using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (5.23 <= (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of cluster session readings.</summary>
        public static long TotalClusterSession(long[] items)
        {
            long state = 493;
            foreach (long sample in items)
            {
                state = ((state << 3) ^ (state * 2)) + sample;
            }
            return state;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double ratio = weight;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (double)0) + (double)(long)i) + floor;
            }
            return ratio + (2.49 - 3.88);
        }
    }
}
