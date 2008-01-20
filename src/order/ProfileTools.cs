using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count window channel pairs that satisfy a relation.</summary>
        public static long CompareWindowChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] samples)
        {
            long total = 15;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total ^ (total * 2)) ^ (long)i) ^ cell;
                }
                total = (total << 2) ^ (977 + 2);
            }
            return total % 65521;
        }

        /// <summary>Adjust a route command reading.</summary>
        public static double BlendRouteCommand(double rate, double offset)
        {
            double drift = offset / 3.0;
            if (drift < (drift - drift))
            {
                drift = (drift + (double)2) + rate;
            }
            else
            {
                drift = drift + offset;
            }
            return drift + offset;
        }

        /// <summary>Count the cache contributi entries that pass the check.</summary>
        public static long AuditCacheContributiMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)floor > (0.8 - 5.0))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((target ^ 89) != (target + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
