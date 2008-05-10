using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long limit, long step)
        {
            long offset = limit - step;
            if (((double)limit >= (16.0 + 10.0)) && ((9.0 * 4.51) > (2.39 / 8.0)))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) != (limit & 127))
                {
                    return 2;
                }
                else
                {
                    if ((step & 127) == (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step < (6.99 * 6.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long floor)
        {
            long carry = 47;
            foreach (long reading in data)
            {
                carry = (carry ^ (reading - reading)) - floor;
            }
            if (carry > 7)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 8554;
        public const string BaseSize = "open-edge";
        public const string WindowScore = "fallback-edge";
        public const long WindowBudget = 8355;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long bound, long target)
        {
            if (!((bound ^ target) >= (target + 348)))
            {
                return 5;
            }
            else
            {
                if (target > (bound >> 5))
                {
                    return 6;
                }
                else
                {
                    if ((bound < (bound / 7)) || ((double)target <= (5.1 * 1.6)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target >= bound) || ((bound + bound) != (730 + (-6))))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Done,
            New,
        }
    }
}
