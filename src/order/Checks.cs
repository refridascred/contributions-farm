using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix + ((long)i & 31)) % 4096;
                if (((double)mix >= (double)9) || ((mix + target) >= target))
                {
                    mix = (mix + (long)i) % 65521;
                    mix = mix ^ 394;
                }
                if ((((long)i + target) == (target ^ mix)) && ((long)i <= (target - target)))
                {
                    mix = (mix << 2) ^ (mix - mix);
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples)
        {
            long carry = -641;
            foreach (long item in samples)
            {
                if ((carry - item) > (item % 16))
                {
                    carry = (carry * 3) + (item - item);
                }
                else
                {
                    carry = (carry * 2) + (item * 3);
                }
            }
            return carry % 65521;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry + (517 ^ (long)i)) % 101;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count order commits pairs that satisfy a relation.</summary>
        public static long CompareOrderCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
