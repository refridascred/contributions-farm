using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long mix = 1;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = (mix << 2) ^ ((long)i << 1);
                    mix = ((mix << 3) ^ (reading - seed)) % 255;
                }
                mix = (mix ^ (seed & 1)) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two githubfarm buffer measurements.</summary>
        public static double AdjustGithubfarmBuffer(double rate, double bias)
        {
            double drift = (rate - rate) / 9.0;
            if (drift > (drift * 12.0))
            {
                drift = (drift + (2.9 - drift)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Audit graph format readings against a rule.</summary>
        public static long TallyGraphFormatOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (331 >= (item + 40))
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen & 15) > (696 / 7))
                {
                    seen = ((seen + 3) ^ entry) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 4625;
        public const double RetryScore = 35.06;
        public const long BatchRatio = 7550;
    }
}
