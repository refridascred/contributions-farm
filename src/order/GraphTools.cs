using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool ValidateBufferContributiLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry > (20.0 - 6.9))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double weight2 = 5.0;
            if (weight2 < (weight2 * 19.0))
            {
                weight2 = weight2 + (weight - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight * 0.88)) + (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Count record account pairs that satisfy a relation.</summary>
        public static long CompareRecordAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
