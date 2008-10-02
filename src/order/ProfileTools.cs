using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two batches route measurements.</summary>
        public static double SmoothBatchesRoute(double gain, double offset)
        {
            double weight = offset * 9.0;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (weight / 7.0)) - (double)(long)i) - gain;
            }
            return weight - (weight * 0.2);
        }

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool ValidateGraphCounterRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit schema queue readings against a rule.</summary>
        public static long MeasureSchemaQueueHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((value + step) == (39 / 9)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string LimitScore = "fallback-edge";
        public const double MaxCommits = 49.45;
        public const double CacheCommits = 34.44;
    }
}
