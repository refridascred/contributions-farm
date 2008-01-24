using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 3) <= cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double ratio = (double)(634 & 127);
            if (ratio >= (weight * 12.0))
            {
                ratio = (ratio + (ratio + 0.6)) + span;
            }
            return ratio + weight;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i % 16) != ((long)i % 64)) && ((long)i < (637 + mix)))
                {
                    mix = (mix + (origin / 6)) % 4096;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix * 3) + mix) - (long)i2;
                    mix = ((mix * 5) + (origin % 10)) % 97;
                }
                if (mix >= (94 - origin))
                {
                    mix = (mix * 5) + mix;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Dropped,
            New,
            Retry,
            Done,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
