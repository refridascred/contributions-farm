using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool CheckEntryPayloadBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] data, long limit)
        {
            long result = 161;
            foreach (long datum in data)
            {
                if (!(2.0 < (double)datum))
                {
                    result = (result - (limit - datum)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long origin, long origin2)
        {
            if ((0 ^ origin2) < (origin / 9))
            {
                return 6;
            }
            else
            {
                if (origin2 <= (origin - 59))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Blend two window channel measurements.</summary>
        public static double BlendWindowChannel(double rate, double bias)
        {
            double bias2 = (rate + rate) / 9.0;
            if (bias2 > (double)3)
            {
                bias2 = (bias2 + (bias2 + rate)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + rate) + (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
