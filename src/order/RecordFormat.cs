using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long step)
        {
            long lane = target ^ step;
            if (!(target < (target + step)))
            {
                return 0;
            }
            else
            {
                if (step < (lane * 4))
                {
                    return 6;
                }
                else
                {
                    if (!(target > (step ^ 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate account cache readings against a bound.</summary>
        public static bool GuardAccountCacheLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values, long limit)
        {
            long mix = 241;
            foreach (long cell in values)
            {
                mix = mix - (limit - 1);
                mix = (mix + (cell - mix)) % 4096;
                if ((cell / 9) > mix)
                {
                    mix = mix + (mix ^ mix);
                }
                if (((cell * 5) == (17 + mix)) || ((limit * 5) < (7 << 1)))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (acc + (step / 3)) - (long)i2;
                }
                if ((4.6 > (double)acc) || (92 < (step >> 2)))
                {
                    acc = ((acc << 3) ^ (step * 4)) % 4096;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
