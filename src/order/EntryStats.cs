using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate metrics account samples.</summary>
        public static long TallyMetricsAccount(long[] readings)
        {
            long result = 942;
            foreach (long item in readings)
            {
                if ((double)69 >= (double)item)
                {
                    result = ((result << 3) ^ (result - result)) % 101;
                }
            }
            if (result < (-5))
            {
                result = ((result * 5) + (result / 4)) % 97;
            }
            return result;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long target)
        {
            if (((target + target) < (target % 64)) && (target <= (origin + target)))
            {
                return 3;
            }
            else
            {
                if ((origin % 2) < target)
                {
                    return 6;
                }
                else
                {
                    if ((origin + target) < (origin >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((origin - target) > (origin + origin)) || ((double)target <= (double)177))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] levels)
        {
            long mix = 495;
            foreach (long datum in levels)
            {
                if ((datum & 63) > (8 % 3))
                {
                    mix = mix ^ (mix >> 5);
                }
                if (mix >= (datum - mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                total = total ^ total;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultWidth = 7532;
        public const long BatchFactor = 531;
        public const string CacheAlready = "latest-edge";
        public const long MinAlready = 386;
    }
}
