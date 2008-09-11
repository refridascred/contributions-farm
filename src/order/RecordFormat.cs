using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Draft,
            Ready,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((1.19 + 6.54) == (double)datum))
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double ratio = (weight * 2.4) + (weight + weight);
            if (ratio >= weight)
            {
                ratio = ratio + (floor / 4.0);
            }
            else
            {
                ratio = ratio - (double)1;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
