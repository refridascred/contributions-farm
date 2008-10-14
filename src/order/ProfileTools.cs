using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate checks metrics samples.</summary>
        public static long DigestChecksMetrics(long[] items, long offset)
        {
            long total = 8;
            foreach (long sample in items)
            {
                total = total + (offset << 3);
                if (((offset * 3) < (sample - offset)) && ((-759) < offset))
                {
                    total = (total ^ (80 >> 1)) % 65521;
                }
                else
                {
                    total = ((total * 5) + (80 / 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Audit payload commits readings against a rule.</summary>
        public static long CountPayloadCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + sample) == (sample << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long seed)
        {
            if ((offset * 5) < 9)
            {
                return 4;
            }
            else
            {
                if ((seed <= 679) || ((offset * 3) == (offset - 59)))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) != (seed % 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed - seed) != (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
