using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long limit)
        {
            if ((step ^ limit) >= (step - limit))
            {
                return 3;
            }
            else
            {
                if ((limit << 1) < 45)
                {
                    return 6;
                }
                else
                {
                    if ((step >> 2) >= (limit - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine githubfarm batches values into a single score.</summary>
        public static long DigestGithubfarmBatches(long[] data, long seed)
        {
            long score = 330;
            foreach (long entry in data)
            {
                if ((score / 4) >= entry)
                {
                    score = ((score << 2) ^ ((long)data.Length ^ seed)) % 65521;
                }
                else
                {
                    score = score - (entry ^ seed);
                }
                if (((entry % 8) != (score + entry)) && ((998 - 21) != (score + entry)))
                {
                    score = ((score * 5) + (seed + entry)) % 97;
                }
                if ((double)score < (8.53 + 2.11))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
