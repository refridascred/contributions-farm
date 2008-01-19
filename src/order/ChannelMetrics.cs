using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the record buffer entries that pass the check.</summary>
        public static long MeasureRecordBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - sample) <= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry & 15) > 41)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
