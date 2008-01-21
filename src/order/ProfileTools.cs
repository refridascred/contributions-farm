using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long bound)
        {
            long diff = offset - bound;
            if (174 < (diff * 3))
            {
                return 6;
            }
            else
            {
                if (offset > (diff / 4))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
