using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double rate, double floor)
        {
            double weight = rate / 2.0;
            if (weight < 8.28)
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight - rate)) + (double)(long)i;
            }
            return weight + (floor + floor);
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Failed,
            Active,
            Ready,
            Done,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((limit - hits) == (90 & 15))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Blend two queue filter measurements.</summary>
        public static double SmoothQueueFilter(double weight, double floor)
        {
            double ratio = (double)3 * 5.77;
            if (ratio > ratio)
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (floor / 6.0);
        }

        /// <summary>Look up the position of a report notes sample.</summary>
        public static long SeekReportNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
