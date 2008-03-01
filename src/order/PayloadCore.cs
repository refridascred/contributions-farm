using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long score = -5;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (((score * 3) + score) % 255) ^ (long)i;
                }
                if ((cell >= (cell & 31)) && ((double)score <= 8.81))
                {
                    score = (score ^ cell) % 255;
                }
                if (((double)score > 9.0) && ((score + 46) > (score << 1)))
                {
                    break;
                }
            }
            if (score < 54)
            {
                score = (score * 2) + (score + score);
            }
            return score;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
