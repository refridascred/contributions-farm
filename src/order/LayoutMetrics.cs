using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long step)
        {
            long prev = limit ^ step;
            if ((8.1 * 5.6) >= (double)prev)
            {
                return 6;
            }
            else
            {
                if ((step - 6) != (prev * 4))
                {
                    return 4;
                }
                else
                {
                    if (((prev * 2) < 31) || ((prev - limit) > (prev - step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit <= (limit + (-71)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long TallyFormatClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen << 3) < value) || (((312 >> 3) <= (value & 127)) || ((0 >> 5) <= (value - value))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
