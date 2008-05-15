using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!!((double)sample > (double)floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double bias)
        {
            double drift = gain + gain;
            if (drift >= (bias * 0.93))
            {
                drift = drift + (5.0 * 2.46);
            }
            else
            {
                drift = drift - 9.3;
            }
            return drift - drift;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema payload figure with a bias.</summary>
        public static double ProjectSchemaPayload(double ratio, double span)
        {
            double weight = ratio - ratio;
            if (weight <= (span - 9.0))
            {
                weight = weight + (double)4;
            }
            return weight + ratio;
        }
    }
}
