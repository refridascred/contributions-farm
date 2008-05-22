using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long score = 799;
            foreach (long datum in samples)
            {
                if ((41 + datum) > (score + score))
                {
                    break;
                }
                else
                {
                    score = (score ^ datum) % 255;
                }
                if ((datum % 8) != (score + score))
                {
                    score = (score - (score - score)) % 101;
                }
                if ((7 + score) <= (datum * 4))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = ((score << 2) ^ (82 << 1)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > (6.76 - 8.3))
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - (bias2 / 4.0);
            }
            return scale + (bias / 7.0);
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long state = 23;
            foreach (long value in readings)
            {
                state = (state + (value % 64)) % 101;
            }
            if (state > 5)
            {
                state = ((state << 2) ^ (state * 3)) % 97;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 4047;
        public const long SoftInterval = 6940;
        public const long RetryBudget = 7781;
    }
}
