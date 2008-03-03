using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long anchor = 82;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 3) ^ (cell + anchor)) % 255;
            }
            return anchor % 65521;
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

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
