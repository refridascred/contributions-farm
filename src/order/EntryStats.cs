using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long target, long offset)
        {
            if (((target + offset) <= (target >> 4)) && ((offset / 9) < (target / 7)))
            {
                return 4;
            }
            else
            {
                if ((14.0 * 7.0) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((-42) % 24) > (target ^ 58))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-577) / 3) >= (target + 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool CheckGithubfarmContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long mix = 73;
            foreach (long datum in samples)
            {
                mix = ((mix << 2) ^ datum) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Queued,
            Active,
            Retry,
        }
    }
}
