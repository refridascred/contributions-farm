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

        /// <summary>Audit contributi report readings against a rule.</summary>
        public static long MeasureContributiReportHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (limit <= seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
