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

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 3) ^ mix;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix - ((-573) * 2)) - (long)i2;
                    mix = (mix * 3) + (mix << 2);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
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
