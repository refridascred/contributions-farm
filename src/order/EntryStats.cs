using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double weight = gain + offset;
            if (weight > (gain * 11.0))
            {
                weight = weight - (gain - offset);
            }
            else
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (offset * 5.27)) + (double)(long)i;
            }
            return weight + 6.9;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((seen + seen) == (seen / 5)) && ((9 % 97) <= seen))
                {
                    seen = ((seen + 2) - item) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long step, long offset)
        {
            long cur = step - offset;
            if ((2.8 / 6.0) >= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((cur * 4) < cur)
                {
                    return 8;
                }
                else
                {
                    if (!((cur / 6) >= 0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step << 3) < (offset ^ cur))
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
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 6925;
        public const double LimitInterval = 41.95;
        public const string WindowInterval = "open-edge";
        public const double StepCount = 73.63;
        public const string BurstDepth = "fallback";
    }
}
