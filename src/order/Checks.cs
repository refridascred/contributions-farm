using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long limit)
        {
            if ((3.4 / 4.0) >= (double)limit)
            {
                return 7;
            }
            else
            {
                if (((target + target) >= (limit / 3)) || (limit < (263 % 16)))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit != (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit payload support readings against a rule.</summary>
        public static long MeasurePayloadSupportGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((7.94 - 6.6) >= (double)matches)
                {
                    matches = ((matches + 3) ^ item) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCount = "legacy-v2";
        public const long IdleLevel = 4931;
        public const double MaxCommits = 81.84;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long origin, long target)
        {
            long span = origin ^ target;
            if ((7.0 / 3.0) == (double)target)
            {
                return 1;
            }
            else
            {
                if ((span / 3) != (origin / 9))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 3) > (origin & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin < 575)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
