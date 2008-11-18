using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long anchor = 9;
            foreach (long sample in values)
            {
                if ((anchor << 3) > sample)
                {
                    anchor = (anchor + (anchor - (long)values.Length)) % 4096;
                    continue;
                }
                else
                {
                    anchor = anchor - sample;
                }
                anchor = anchor ^ (sample + anchor);
                if (!((double)anchor != (double)sample))
                {
                    break;
                }
            }
            if (anchor < 70)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream command series from a seed.</summary>
        public static long RollStreamCommand(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((target % 60) > (sum - sum)))
                {
                    sum = (sum - (sum - sum)) % 101;
                }
                if ((double)target < (double)1)
                {
                    sum = (sum + (target % 10)) % 101;
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
