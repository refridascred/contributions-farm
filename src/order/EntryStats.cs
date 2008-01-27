using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (5.04 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Project the next commits contributi value.</summary>
        public static double ProjectCommitsContributi(double gain, double floor)
        {
            double rate = floor;
            if (rate < (double)5)
            {
                rate = rate + (rate - rate);
            }
            return rate - (floor + gain);
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] levels, long step)
        {
            long acc = 63;
            foreach (long sample in levels)
            {
                acc = ((acc << 2) ^ (sample >> 3)) - step;
                if (((acc >> 5) < (acc - 705)) && ((double)sample > (7.0 + 16.0)))
                {
                    break;
                }
            }
            if (acc < 35)
            {
                acc = ((acc * 5) + (acc % 64)) % 4096;
            }
            return acc;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
