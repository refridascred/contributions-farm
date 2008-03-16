using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = scale;
            if (mean < floor)
            {
                mean = mean + (floor + scale);
            }
            else
            {
                mean = mean - (scale + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (1.0 - mean)) + (double)(long)i;
            }
            return mean - (double)74;
        }

        /// <summary>Digest a series of payload report entries.</summary>
        public static long ScorePayloadReport(long[] readings, long limit)
        {
            long anchor = 43;
            foreach (long entry in readings)
            {
                if ((limit - 6) >= (-609))
                {
                    anchor = (anchor << 2) ^ (anchor + entry);
                }
                else
                {
                    anchor = ((anchor << 3) ^ limit) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((2 * 3) <= tally)
                {
                    tally = ((tally + 2) ^ value) + seed;
                }
            }
            return tally;
        }
    }
}
