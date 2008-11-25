using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample + (long)series.Length) == (sample & 31)) || !((2.8 + 15.0) == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter session samples.</summary>
        public static long FoldFilterSession(long[] readings)
        {
            long score = 108;
            foreach (long cell in readings)
            {
                score = ((score * 3) + (cell + score)) % 255;
                score = score - cell;
                if (((score & 15) > 76) && ((score - score) != (score & 3)))
                {
                    score = (score - (score + score)) % 1000;
                }
                else
                {
                    score = (score << 3) ^ (1 * 5);
                }
            }
            if (score < 138)
            {
                score = ((score * 5) + (score % 64)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Dropped,
            Failed,
            Idle,
        }
    }
}
