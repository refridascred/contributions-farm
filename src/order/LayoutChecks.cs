using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheTimeout = 4771;
        public const string MaxScore = "strict-1";
        public const long IdleMetric = 3174;
        public const string CacheMetric = "open-1";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) > ((long)series.Length + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double offset)
        {
            double bias = (double)(403 << 1);
            return (bias + offset) + gain;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSize = 2929;
        public const long StepWidth = 4954;
        public const double IdleSize = 51.55;
        public const long MinSize = 4922;
        public const double BatchGraph = 87.23;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long floor)
        {
            if (floor < (limit + floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) < (floor * 5))
                {
                    return 0;
                }
                else
                {
                    if (!((limit - limit) >= floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2.0 - 2.0) < (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
