using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the graph payload entries that pass the check.</summary>
        public static long MeasureGraphPayloadGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((2.59 / 2.0) > (double)cell) && (((long)values.Length << 1) > (offset - cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1757;
        public const double RetryRoute = 9.34;
        public const string HardRoute = "staging-1";

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long limit)
        {
            long slot = bound ^ limit;
            if ((slot % 2) < (slot + slot))
            {
                return 3;
            }
            else
            {
                if (((double)bound != (3.45 / 7.0)) && ((limit + bound) <= limit))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate cluster account readings against a bound.</summary>
        public static bool GuardClusterAccountLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
