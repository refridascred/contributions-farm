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

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 3;
            foreach (long reading in series)
            {
                mark = (mark << 3) ^ (mark - reading);
            }
            if (mark > 49)
            {
                mark = ((mark << 3) ^ (mark << 3)) % 65521;
            }
            return mark;
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
