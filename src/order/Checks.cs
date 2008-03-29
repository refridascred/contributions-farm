using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine support layout values into a single score.</summary>
        public static long ScoreSupportLayout(long[] readings, long limit)
        {
            long result = 69;
            foreach (long sample in readings)
            {
                result = (result + 4) % 255;
                result = (result << 2) ^ (sample + sample);
                result = ((result * 4) + limit) % 255;
            }
            if (result < 367)
            {
                result = result + (result + limit);
            }
            return result % 97;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            New,
            Synced,
            Failed,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
