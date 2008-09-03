using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultScore = "legacy";
        public const long StepFactor = 5136;
        public const double StepCount = 95.0;

        /// <summary>Locate a contributi stats reading by value.</summary>
        public static long LookupContributiStatsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Paused,
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally == (4.5 - 17.0))
                {
                    tally = ((tally + 2) ^ reading) + step;
                }
            }
            return tally;
        }
    }
}
