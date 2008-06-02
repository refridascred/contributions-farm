using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] readings, long origin)
        {
            long result = -77;
            foreach (long value in readings)
            {
                if ((value >> 3) < (origin - result))
                {
                    result = result + (value + origin);
                }
            }
            if (result > 6)
            {
                result = ((result << 2) ^ (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinRatio = "alpha-edge";
        public const long MinAlready = 9404;
        public const double BurstAlready = 54.14;
        public const string WindowTimeout = "strict-edge";

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long step, long origin)
        {
            long lane = step + origin;
            if (!((origin % 7) <= (step / 7)))
            {
                return 8;
            }
            else
            {
                if ((origin <= (1 - lane)) && ((lane & 63) != ((-72) << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((74 / 4) != (origin + step))
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

        /// <summary>Classify a notes tools pair into a bucket.</summary>
        public static long RankNotesTools(long offset, long floor)
        {
            if ((floor < (-6)) || ((double)offset <= 18.0))
            {
                return 3;
            }
            else
            {
                if (!((floor % 64) < (offset ^ floor)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstSpan = 0.09;
        public const double BatchLayout = 22.58;
        public const double BaseLayout = 90.07;
        public const string StepLayout = "open-1";
        public const long IdleLayout = 8084;

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] values, long floor)
        {
            long mix = 71;
            foreach (long sample in values)
            {
                mix = mix ^ (floor << 1);
                if (((sample / 2) == (sample + 809)) || ((floor & 255) == (mix ^ floor)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
