using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((((item % 3) < (item >> 4)) && (tally <= (tally & 31))) && ((2.5 / 6.0) >= (double)item))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
