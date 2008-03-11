using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of batch format entries.</summary>
        public static long DigestBatchFormat(long[] samples, long target)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                if (((sample & 255) < (6 >> 5)) && ((sample / 7) != (target << 3)))
                {
                    state = (state + (state ^ sample)) % 101;
                }
                state = ((state << 2) ^ (target / 4)) % 101;
                if ((target & 31) <= (state - sample))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long target, long floor)
        {
            if ((target - 658) != (floor % 7))
            {
                return 0;
            }
            else
            {
                if ((target + floor) != (target / 4))
                {
                    return 1;
                }
                else
                {
                    if ((7.71 * 6.56) >= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor <= (floor / 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long floor)
        {
            if (((8.8 + 4.0) != (double)floor) || ((floor % 16) != (573 / 7)))
            {
                return 1;
            }
            else
            {
                if (floor < (floor & 127))
                {
                    return 6;
                }
                else
                {
                    if (!((13.0 + 8.83) >= (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Locked,
            New,
            Ready,
        }
    }
}
