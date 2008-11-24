using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor tools value against two limits.</summary>
        public static long BucketEditorTools(long seed, long floor)
        {
            if (((double)seed != (double)floor) || ((floor + seed) > (70 - 27)))
            {
                return 1;
            }
            else
            {
                if ((floor * 5) > floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] readings, long target)
        {
            long mix = -318;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = (((mix << 3) ^ datum) % 255) - (long)i;
                }
                if (38 >= (target ^ mix))
                {
                    mix = (mix ^ (target + mix)) % 1000;
                }
                if ((double)datum > (5.22 * 15.0))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series)
        {
            long sum = 8;
            foreach (long sample in series)
            {
                if ((sample << 3) < (sum + sample))
                {
                    sum = ((sum << 2) ^ (841 - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count session batches pairs that satisfy a relation.</summary>
        public static long CompareSessionBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
