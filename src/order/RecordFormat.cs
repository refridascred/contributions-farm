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

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheScore = 4625;
        public const double RetryScore = 35.06;
        public const long BatchRatio = 7550;
    }
}
