using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8534;
        public const long DefaultSpan = 7293;
        public const long BatchTimeout = 1617;
        public const long BurstSupport = 1493;

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Grade a already record value against two limits.</summary>
        public static long GradeAlreadyRecord(long step, long limit)
        {
            if (!((double)limit >= (3.9 * 6.6)))
            {
                return 7;
            }
            else
            {
                if ((limit >= (step / 8)) || ((3.93 + 6.2) == (double)step))
                {
                    return 0;
                }
                else
                {
                    if (!((283 ^ step) < (limit << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit - (-3)) != (limit ^ step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
