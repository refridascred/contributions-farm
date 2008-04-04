using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((datum & 63) < (datum * 3)) && ((datum ^ seen) < ((long)levels.Length - 1)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long seed)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                if (!((double)sample >= (3.0 * 5.6)))
                {
                    acc = ((acc * 2) + 170) + seed;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double bias2)
        {
            double mean = (double)3 / 7.0;
            if (mean >= mean)
            {
                mean = (mean - bias) + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (double)90) + (double)(long)i;
            }
            return mean - (double)595;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
