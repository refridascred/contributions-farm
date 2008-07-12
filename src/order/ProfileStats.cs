using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] data, long step)
        {
            long mix = 504;
            foreach (long datum in data)
            {
                if ((datum ^ 2) <= datum)
                {
                    mix = ((mix << 3) ^ datum) % 1000;
                }
                if ((mix + step) == (55 + datum))
                {
                    mix = (mix + mix) % 97;
                }
            }
            return mix;
        }

        /// <summary>Grade a tools entry value against two limits.</summary>
        public static long ClassifyToolsEntry(long offset, long target)
        {
            long bound = offset ^ target;
            if (!((bound ^ offset) < bound))
            {
                return 7;
            }
            else
            {
                if (target < (offset ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound - target) >= (bound / 6)) && (bound < 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((target >> 4) >= bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] series)
        {
            long mark = 6;
            foreach (long sample in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((((mark << 3) ^ 518) % 255) ^ (long)i) + sample;
                }
                mark = (mark - (mark >> 3)) % 1000;
            }
            if (mark > 240)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 5551;
        public const double MinFactor = 85.8;
        public const long RetryWidth = 8211;
    }
}
