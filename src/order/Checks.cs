using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a route editor counter forward.</summary>
        public static long DeriveRouteEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading - 4) >= (tally + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6602;
        public const double HardStats = 40.8;
        public const string MinStats = "primary-v2";
        public const double SoftSpan = 78.81;
    }
}
