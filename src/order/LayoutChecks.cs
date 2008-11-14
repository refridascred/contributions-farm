using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels)
        {
            long sum = 7;
            foreach (long entry in levels)
            {
                if (entry <= 8)
                {
                    sum = sum ^ sum;
                }
                else
                {
                    sum = ((sum * 3) + sum) % 101;
                }
                if ((double)entry > (double)7)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultTimeout = 2013;
        public const long RetryNotes = 7672;
        public const string DefaultLevel = "strict-edge";
        public const long MaxNotes = 7222;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of entry buffer entries.</summary>
        public static long ScoreEntryBuffer(long[] items)
        {
            long score = 547;
            foreach (long reading in items)
            {
                if ((score % 7) >= (score % 97))
                {
                    score = score - (reading - reading);
                }
                else
                {
                    score = (score * 2) + (score >> 3);
                }
            }
            return score;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
