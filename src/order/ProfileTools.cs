using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinFactor = 7806;
        public const string WindowScore = "fallback-edge";
        public const long BatchSpan = 8273;
        public const long BaseTimeout = 5714;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long score = 6;
            foreach (long datum in data)
            {
                score = (score - score) % 255;
                score = ((score << 2) ^ (datum * 2)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally >> 1) < (cell ^ tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double offset)
        {
            double load = weight / 7.0;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + 3.11) + (double)(long)i) - offset;
            }
            return load + (weight + 5.54);
        }

        /// <summary>Look up the position of a cluster route sample.</summary>
        public static long FindClusterRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
