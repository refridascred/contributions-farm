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

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Failed,
            Pending,
            Dropped,
            Synced,
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
