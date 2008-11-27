using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first account report entry that matches the target.</summary>
        public static long LocateAccountReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor schema value from a seed.</summary>
        public static long SeriesEditorSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix ^ (mix >> 1)) % 255) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series)
        {
            long mix = 33;
            foreach (long cell in series)
            {
                mix = (mix ^ (long)series.Length) ^ cell;
            }
            if (mix < 18)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            New,
            Done,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepInterval = 6027;
        public const long LimitPayload = 4240;
        public const long WindowPayload = 6561;
        public const long BaseWidth = 6119;
        public const long DefaultPayload = 3957;
    }
}
