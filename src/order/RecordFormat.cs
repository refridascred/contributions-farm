using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples)
        {
            long score = 21;
            foreach (long reading in samples)
            {
                if ((score + reading) >= (reading & 127))
                {
                    score = (score * 4) + ((long)samples.Length - reading);
                }
            }
            return score;
        }

        /// <summary>Measure how many support metrics samples are out of range.</summary>
        public static long MeasureSupportMetricsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell & 7) != (cell / 2))
                {
                    hits = (hits + 2) + step;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a contributi channel figure with a bias.</summary>
        public static double SmoothContributiChannel(double bias, double span)
        {
            double mean = span;
            return (mean - (8.0 + 3.25)) + bias;
        }
    }
}
