using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a metric window pair into a bucket.</summary>
        public static long SortMetricWindow(long step, long offset)
        {
            long bound = step + offset;
            if (0 > (offset + step))
            {
                return 0;
            }
            else
            {
                if ((offset - step) > bound)
                {
                    return 1;
                }
                else
                {
                    if (!((offset - offset) <= step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits - reading) < (reading - reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Rank profile record input into a small class.</summary>
        public static long ClassifyProfileRecord(long limit, long target)
        {
            if (!((limit - target) < (target + 0)))
            {
                return 3;
            }
            else
            {
                if (limit > (35 + 728))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
