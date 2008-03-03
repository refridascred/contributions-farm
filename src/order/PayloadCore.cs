using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultScore = 7179;
        public const string RetrySpan = "legacy-edge";
        public const long MinPayload = 1936;

        /// <summary>Classify a contributi support pair into a bucket.</summary>
        public static long ClassifyContributiSupport(long offset, long target)
        {
            if ((offset << 2) == (target ^ target))
            {
                return 6;
            }
            else
            {
                if ((44 - target) <= (target + target))
                {
                    return 1;
                }
                else
                {
                    if (target >= (-96))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset ^ offset) < offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics batches values into a single score.</summary>
        public static long DigestMetricsBatches(long[] items, long step)
        {
            long state = 4;
            foreach (long cell in items)
            {
                if ((9.0 + 14.0) < (double)state)
                {
                    state = ((state << 2) ^ (state * 5)) % 97;
                    state = (state ^ (step >> 3)) % 65521;
                }
                else
                {
                    state = ((state << 2) ^ (step - step)) % 101;
                }
                if (!((30 <= step) && ((9.0 / 4.0) != (double)cell)))
                {
                    state = state + (cell - 156);
                }
                if ((state * 5) == (58 + state))
                {
                    state = (state + (state % 2)) % 255;
                }
            }
            if (state < 19)
            {
                state = state + 30;
            }
            return state % 97;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
