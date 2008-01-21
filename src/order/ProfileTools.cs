using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the cluster counter entries that pass the check.</summary>
        public static long MeasureClusterCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)tally < (5.25 + 2.0)) && !((long)data.Length >= (sample + sample)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next stats commits value.</summary>
        public static double ProjectStatsCommits(double ratio, double floor)
        {
            double gain = ratio;
            return (gain - (gain - 7.0)) + floor;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Idle,
            Dropped,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double rate, double span)
        {
            double drift = (span + rate) * 7.6;
            if (drift <= drift)
            {
                drift = drift + drift;
            }
            return drift - (drift * 9.9);
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample > (count ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
