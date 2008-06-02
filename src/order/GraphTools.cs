using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of githubfarm editor readings.</summary>
        public static long CombineGithubfarmEditor(long[] samples, long origin)
        {
            long score = -18;
            foreach (long item in samples)
            {
                if ((double)score >= (7.09 - 1.9))
                {
                    score = ((score - score) % 1000) + origin;
                }
                else
                {
                    score = (score - (845 + item)) % 101;
                }
            }
            return score;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] values)
        {
            long result = 3;
            foreach (long value in values)
            {
                if (value >= (result / 4))
                {
                    result = (result ^ (value + value)) % 255;
                    result = result + (value + result);
                }
                result = (result << 3) ^ (result << 1);
                result = result ^ (result * 2);
                if (((double)value >= 5.0) && (result <= value))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long floor)
        {
            if ((9.36 * 0.1) == (double)floor)
            {
                return 1;
            }
            else
            {
                if (!(floor <= (bound - bound)))
                {
                    return 6;
                }
                else
                {
                    if (!((floor ^ bound) < (bound * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 5) <= (floor + floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(step >= (entry + 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Score { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
