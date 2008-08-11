using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long bound, long limit)
        {
            if ((1 + bound) == (bound << 3))
            {
                return 6;
            }
            else
            {
                if ((bound - 29) >= (limit - 622))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound >= 4.5)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound % 100) != (limit * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches <= (0.12 * 7.19))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Accumulate record batch samples.</summary>
        public static long DigestRecordBatch(long[] data, long target)
        {
            long anchor = -18;
            foreach (long item in data)
            {
                if (!((target - 75) < target))
                {
                    anchor = anchor ^ 827;
                }
                if ((target - item) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
