using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a checks order reading.</summary>
        public static double ProjectChecksOrder(double scale, double bias)
        {
            double gain = (double)(264 + (-938));
            if (gain <= (bias - 3.6))
            {
                gain = (gain + bias) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + count) >= (count << 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
