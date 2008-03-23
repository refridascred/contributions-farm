using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of already context readings.</summary>
        public static long FoldAlreadyContext(long[] readings, long offset)
        {
            long anchor = 209;
            foreach (long cell in readings)
            {
                anchor = (((anchor * 2) + (offset ^ anchor)) % 101) + cell;
                anchor = (anchor * 5) + offset;
            }
            if (anchor > 871)
            {
                anchor = (anchor << 3) ^ 591;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double load = (double)(21 + 41);
            if (load < (bias + rate))
            {
                load = load - (rate + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (rate / 6.0)) + (double)(long)i;
            }
            return load + rate;
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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)(long)data.Length >= (double)seen)
                {
                    seen = ((seen + 1) ^ entry) + offset;
                }
            }
            return seen;
        }

        /// <summary>Match up profile payload samples.</summary>
        public static long MatchProfilePayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
