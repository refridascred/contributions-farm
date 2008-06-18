using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] samples, long seed)
        {
            long anchor = 54;
            foreach (long item in samples)
            {
                if ((seed % 64) > 0)
                {
                    anchor = (anchor << 2) ^ (item + anchor);
                }
                if ((seed * 2) <= (736 + item))
                {
                    break;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 2) ^ ((long)samples.Length - anchor)) % 101;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Queued,
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2155;
        public const long WindowLevel = 7140;
        public const string StepInterval = "open";
        public const string BurstStats = "strict-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 56.07;
        public const double CacheRatio = 85.2;
        public const long CacheSize = 6968;
        public const long MaxSize = 2903;
        public const long BatchAlready = 6734;

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double drift = (double)406 * 4.0;
            if (drift >= drift)
            {
                drift = drift + (double)905;
            }
            else
            {
                drift = drift - offset;
            }
            return drift + (rate + offset);
        }
    }
}
