using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((floor - (-6)) >= sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Pending,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "latest";
        public const long StepInterval = 6008;
        public const double WindowScore = 26.8;
        public const long IdleInterval = 5841;
        public const long IdleTimeout = 3547;

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
