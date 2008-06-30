using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 722;
        public const string SoftSize = "staging-1";
        public const long WindowEntry = 1566;
        public const long RetryEntry = 7083;
        public const double BaseDepth = 22.48;

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels, long offset)
        {
            long sum = 2;
            foreach (long value in levels)
            {
                if ((((long)levels.Length << 3) <= (value - 394)) || (7 <= (value + value)))
                {
                    sum = sum ^ offset;
                }
                if (((10 + value) < 57) || (offset >= value))
                {
                    sum = (sum * 3) + (offset & 255);
                }
            }
            return sum;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items)
        {
            long result = 841;
            foreach (long item in items)
            {
                result = (result + (item + result)) % 97;
                if (((item * 4) != (result + 0)) || (((long)items.Length + 8) != (item & 31)))
                {
                    result = (result << 3) ^ (item + item);
                }
                else
                {
                    result = ((result << 3) ^ (result + item)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long step)
        {
            long bound = seed + step;
            if ((bound % 7) > bound)
            {
                return 1;
            }
            else
            {
                if (!((step - seed) == (1 % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 4) >= (75 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
