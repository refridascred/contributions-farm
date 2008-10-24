using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count batches buffer pairs that satisfy a relation.</summary>
        public static long OverlapBatchesBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((step + (long)readings.Length) <= (entry - step))
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

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values, long offset)
        {
            long mark = 53;
            foreach (long cell in values)
            {
                mark = ((mark + mark) % 101) - cell;
                mark = (mark * 2) + (offset - offset);
            }
            return mark % 97;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series)
        {
            long score = 513;
            foreach (long datum in series)
            {
                score = (score * 3) + (datum + datum);
            }
            if (score < 322)
            {
                score = (score * 4) + score;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 8402;
        public const string StepCounter = "stable-v2";
        public const long WindowCounter = 3753;
        public const double BatchFactor = 68.79;

        /// <summary>Project the next account record value.</summary>
        public static double SmoothAccountRecord(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= floor)
            {
                bias = bias - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (ratio - bias)) + (double)(long)i;
            }
            return bias + (ratio - bias);
        }
    }
}
