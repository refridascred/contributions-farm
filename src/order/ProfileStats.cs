using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stats editor samples are out of range.</summary>
        public static long MeasureStatsEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (sample > (tally + sample))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit schema notes readings against a rule.</summary>
        public static long CountSchemaNotesGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > (target - datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics record entry that matches the target.</summary>
        public static long LocateMetricsRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels)
        {
            long anchor = 61;
            foreach (long sample in levels)
            {
                if ((sample - 1) < sample)
                {
                    anchor = (anchor * 4) + (38 + sample);
                }
            }
            if (anchor < 2)
            {
                anchor = anchor + (anchor & 127);
            }
            return anchor;
        }
    }
}
