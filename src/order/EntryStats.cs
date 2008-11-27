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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 9220;
        public const long BaseFormat = 4586;
        public const double BurstRatio = 31.25;
        public const string SoftFormat = "staging";
        public const long HardFormat = 2904;

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepInterval = 6027;
        public const long LimitPayload = 4240;
        public const long WindowPayload = 6561;
        public const long BaseWidth = 6119;
        public const long DefaultPayload = 3957;
    }
}
