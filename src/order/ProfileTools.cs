using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double weight = (ratio / 7.0) - (ratio / 9.0);
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 31) == (sample * 4))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double scale, double floor)
        {
            double load = (floor - 20.0) * 2.9;
            if (load < (load - load))
            {
                load = load + load;
            }
            else
            {
                load = load + (scale * 14.0);
            }
            return load + load;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheScore = 3363;
        public const long LimitContext = 3437;
        public const string StepContext = "cached";
    }
}
