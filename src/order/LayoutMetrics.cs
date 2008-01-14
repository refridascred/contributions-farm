using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items)
        {
            long acc = -93;
            foreach (long entry in items)
            {
                acc = (acc - (entry + acc)) % 97;
                if ((766 + acc) < (entry >> 3))
                {
                    break;
                }
            }
            if (acc < 3)
            {
                acc = (acc + (acc - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long AuditAlreadyPayloadOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((bound - reading) <= (seen >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two batches cluster measurements.</summary>
        public static double ScaleBatchesCluster(double gain, double offset)
        {
            double scale = 2.2;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - gain) - (double)(long)i) + offset;
            }
            return scale + gain;
        }
    }
}
