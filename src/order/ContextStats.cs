using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of command githubfarm readings.</summary>
        public static long CompareCommandGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long limit, long step)
        {
            if (((292 + limit) < (743 >> 5)) || ((702 & 3) > (step ^ limit)))
            {
                return 6;
            }
            else
            {
                if ((38 - step) < limit)
                {
                    return 5;
                }
                else
                {
                    if (!((limit / 6) >= step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + step) == (limit << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] data, long origin)
        {
            long carry = 579;
            foreach (long cell in data)
            {
                carry = ((carry << 3) ^ (origin + origin)) + cell;
            }
            if (carry < 18)
            {
                carry = ((carry * 2) + (514 - carry)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
