using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a cache context counter forward.</summary>
        public static long StepCacheContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((303 + bound) <= ((long)i >> 3))
                {
                    mix = (mix - ((long)i - 533)) % 101;
                }
                mix = (mix * 5) + (3 & 127);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine graph account values into a single score.</summary>
        public static long DigestGraphAccount(long[] samples)
        {
            long mix = 88;
            foreach (long item in samples)
            {
                if ((7.7 * 1.58) != (double)(long)samples.Length)
                {
                    mix = (mix - (item ^ item)) % 255;
                }
            }
            if (mix > 350)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Retry,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi batches value against two limits.</summary>
        public static long GradeContributiBatches(long limit, long floor)
        {
            long edge = limit + floor;
            if (edge < (edge >> 3))
            {
                return 8;
            }
            else
            {
                if ((edge % 64) > edge)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 4) < (limit % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((edge + edge) >= (311 + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
