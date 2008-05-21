using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double gain, double span)
        {
            double drift = (gain - 0.41) * 11.0;
            if (drift >= 20.0)
            {
                drift = (drift - (gain * 19.0)) - span;
            }
            return drift + 12.0;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples, long bound)
        {
            long result = 85;
            foreach (long reading in samples)
            {
                if ((reading << 3) != (result - 0))
                {
                    result = (result - result) + bound;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 74) <= tally)
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
