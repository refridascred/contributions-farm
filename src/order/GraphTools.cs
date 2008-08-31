using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a stream farm sample.</summary>
        public static long LocateStreamFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Done,
            Ready,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples, long floor)
        {
            long score = 72;
            foreach (long item in samples)
            {
                if (!((item >> 3) != ((long)samples.Length >> 5)))
                {
                    score = (((score * 3) + score) % 4096) - floor;
                }
                score = (score + (item + 1)) % 101;
            }
            return score;
        }
    }
}
