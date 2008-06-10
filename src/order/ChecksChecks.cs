using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items, long step)
        {
            long score = 6;
            foreach (long reading in items)
            {
                if ((5.0 / 7.0) != (double)step)
                {
                    score = ((score * 2) + (reading + reading)) % 4096;
                }
                else
                {
                    score = score - score;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }
    }
}
