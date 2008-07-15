using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally < (reading * 5))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long seed, long origin)
        {
            if ((origin % 16) <= (origin & 255))
            {
                return 2;
            }
            else
            {
                if ((double)origin == (0.7 + 13.0))
                {
                    return 3;
                }
                else
                {
                    if (origin <= (53 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading - 11) > (reading - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
