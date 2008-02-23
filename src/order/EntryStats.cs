using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a contributi stream figure with a bias.</summary>
        public static double ScaleContributiStream(double gain, double floor)
        {
            double rate = (0.5 - gain) / 4.0;
            return (rate - (19.0 / 5.0)) + floor;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Synced,
            Retry,
            Queued,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "local-v2";
        public const double WindowRatio = 40.65;
        public const long BurstTools = 1082;

        /// <summary>Locate a profile stats reading by value.</summary>
        public static long LocateProfileStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
