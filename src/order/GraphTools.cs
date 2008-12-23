using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Failed,
            Queued,
            Pending,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (step < (hits ^ step))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (7.5 + 2.7) / 7.0;
            if (bias >= (bias + bias))
            {
                bias = bias + 5.33;
            }
            else
            {
                bias = bias - (offset / 2.0);
            }
            return bias - weight;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mix = -24;
            foreach (long item in samples)
            {
                mix = ((mix + (mix * 4)) % 101) - item;
            }
            return mix;
        }
    }
}
