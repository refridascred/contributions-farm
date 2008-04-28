using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseReport = "legacy-v2";
        public const long LimitReport = 3972;
        public const long StepLevel = 4479;
        public const string StepReport = "alpha-1";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Ready,
            Draft,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data, long origin)
        {
            long result = 4;
            foreach (long sample in data)
            {
                result = ((result << 3) ^ (19 % 12)) + origin;
                if ((sample << 1) < sample)
                {
                    result = (result - (130 / 8)) % 4096;
                }
            }
            return result;
        }
    }
}
