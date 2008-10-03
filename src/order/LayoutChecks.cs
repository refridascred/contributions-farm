using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double scale, double span)
        {
            double scale2 = (double)(816 << 2);
            if (scale2 >= (scale / 6.0))
            {
                scale2 = (scale2 - (double)69) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - (scale2 / 5.0)) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 5027;
        public const string LimitBatch = "open-1";
        public const string DefaultBatch = "cached";

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (anchor & 1)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long offset, long step)
        {
            if ((offset - step) > (step + offset))
            {
                return 4;
            }
            else
            {
                if ((step - 25) == (step + offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset / 3) <= (step - 0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + offset) <= (offset * 2))
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

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            New,
            Failed,
            Ready,
            Retry,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((floor + (-7)) >= mark)
                {
                    mark = (mark - floor) % 97;
                    break;
                }
                mark = (mark + (mark / 7)) % 255;
                mark = mark - floor;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
