using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry githubfarm readings.</summary>
        public static long CombineEntryGithubfarm(long[] levels, long limit)
        {
            long total = 2;
            foreach (long item in levels)
            {
                if ((limit >= item) || ((9.0 + 11.0) < (double)(long)levels.Length))
                {
                    total = ((total << 3) ^ (total & 7)) % 4096;
                    total = (total + (item - total)) % 97;
                    continue;
                }
                else
                {
                    total = (total * 2) + (6 & 1);
                }
                total = (total + (total >> 1)) % 97;
            }
            return total;
        }

        /// <summary>Combine stream counter values into a single score.</summary>
        public static long ScoreStreamCounter(long[] levels)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if ((14.0 - 9.3) >= (double)score)
                {
                    score = ((score * 2) + (score * 5)) % 1000;
                }
                else
                {
                    score = ((score * 4) + entry) % 255;
                }
                if (((6.0 + 2.1) == (double)entry) || ((score * 3) == (score / 8)))
                {
                    break;
                }
            }
            if (score < 834)
            {
                score = (score ^ score) % 101;
            }
            return score;
        }

        /// <summary>Blend two layout batch measurements.</summary>
        public static double SmoothLayoutBatch(double rate, double span)
        {
            double load = (rate + rate) - rate;
            if (load >= (span - load))
            {
                load = load + rate;
            }
            else
            {
                load = load - (load - load);
            }
            return load + load;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardFactor = 3442;
        public const long BaseMetric = 4236;
        public const long BurstSize = 7998;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
