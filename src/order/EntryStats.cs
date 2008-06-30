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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally + seed) != (value - (-39)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
