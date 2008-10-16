using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] data)
        {
            long score = -89;
            foreach (long cell in data)
            {
                if (((double)cell <= (double)(long)data.Length) || ((double)cell < 6.03))
                {
                    score = ((score << 2) ^ score) % 101;
                }
            }
            if (score < 7)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long offset)
        {
            if ((offset < (1 ^ step)) && ((step / 4) <= (3 % 3)))
            {
                return 7;
            }
            else
            {
                if ((5 + offset) <= offset)
                {
                    return 5;
                }
                else
                {
                    if (step >= (89 % 10))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Label { get; set; }
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long sum = 8;
            foreach (long datum in series)
            {
                if (datum < (sum % 3))
                {
                    sum = (sum ^ (datum + datum)) % 255;
                }
                sum = (sum * 3) + (datum - datum);
                sum = sum ^ (datum - sum);
            }
            return sum;
        }
    }
}
