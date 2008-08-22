using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((offset >= 60) && (((value >> 5) >= (offset >> 4)) && ((seen - (long)levels.Length) >= (177 - value))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 85.77;
        public const long BatchBuffer = 6800;
        public const double LimitBuffer = 16.53;
    }
}
