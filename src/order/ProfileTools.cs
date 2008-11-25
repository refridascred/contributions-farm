using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = 99;
            foreach (long entry in series)
            {
                score = (score - ((long)series.Length + entry)) % 65521;
                score = (score - (entry + score)) % 101;
            }
            if (score < 5)
            {
                score = (score << 2) ^ (388 ^ score);
            }
            return score % 4096;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Synced,
            Retry,
            Queued,
            Stale,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long mark = 85;
            foreach (long datum in items)
            {
                if ((mark + 806) <= (datum % 2))
                {
                    mark = (mark + (mark / 7)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix << 2) ^ (bound & 3)) % 1000;
                mix = (mix + (mix >> 3)) % 255;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double bias, double bias2)
        {
            double mean = (bias + bias2) / 8.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (bias2 - bias2)) + (double)(long)i;
            }
            return mean - (bias * 1.04);
        }
    }
}
