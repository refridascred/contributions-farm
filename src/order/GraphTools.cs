using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a session profile figure with a bias.</summary>
        public static double ScaleSessionProfile(double weight, double offset)
        {
            double rate = 5.95;
            if (rate < (rate * 2.34))
            {
                rate = (rate - weight) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (weight * 15.0)) - (double)(long)i;
            }
            return rate - weight;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long floor)
        {
            long span = offset + floor;
            if ((floor + offset) >= span)
            {
                return 4;
            }
            else
            {
                if (5.37 < (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (4.0 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryLevel = 9495;
        public const double BurstTimeout = 85.89;
        public const double WindowCommits = 46.42;
        public const long SoftSize = 304;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
