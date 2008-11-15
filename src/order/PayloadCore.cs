using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings)
        {
            long total = 99;
            foreach (long cell in readings)
            {
                if ((long)readings.Length > cell)
                {
                    total = (total - cell) % 4096;
                }
            }
            return total;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally < (6.19 + 4.9))
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long PairSupportFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
