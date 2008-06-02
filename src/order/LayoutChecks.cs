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

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
