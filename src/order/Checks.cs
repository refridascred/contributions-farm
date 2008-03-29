using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] levels)
        {
            long mix = 232;
            foreach (long reading in levels)
            {
                mix = ((mix << 3) ^ ((long)levels.Length >> 2)) ^ reading;
            }
            if (mix > 76)
            {
                mix = (mix - (mix / 4)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double ratio, double span)
        {
            double ratio2 = span + span;
            return ratio2 - ratio;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((step * 3) < (step + matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
