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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long floor)
        {
            if (((0.22 + 6.4) == (double)limit) && ((limit - floor) >= (39 - limit)))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (3.3 - 1.95))
                {
                    return 4;
                }
                else
                {
                    if (!(limit > (floor * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor % 10) == (6 << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
