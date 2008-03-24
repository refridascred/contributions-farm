using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] series)
        {
            long score = -502;
            foreach (long value in series)
            {
                if (((7 % 5) < (score + score)) && ((35 & 31) <= (score ^ value)))
                {
                    score = (score ^ (46 + score)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] values, long target)
        {
            long mark = 251;
            foreach (long reading in values)
            {
                long step = (target >> 5) - (reading ^ target);
                mark = mark - (step << 2);
                if (((double)mark == (double)reading) && ((reading + mark) != (target + mark)))
                {
                    mark = (mark ^ 8) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Queued,
            Draft,
            Ready,
        }
    }
}
