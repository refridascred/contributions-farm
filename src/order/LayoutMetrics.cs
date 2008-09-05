using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepInterval = 9001;
        public const long HardLevel = 709;
        public const long SoftRoute = 4588;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((1.0 * 7.9) > (double)mark)
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                    break;
                }
                else
                {
                    mark = (mark ^ (offset & 127)) % 4096;
                }
                mark = (mark - (mark << 1)) % 255;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long origin2)
        {
            long span = origin ^ origin2;
            if (((double)origin >= (4.0 * 8.9)) || (1.3 < (double)origin2))
            {
                return 3;
            }
            else
            {
                if (((span % 64) <= span) && ((origin + span) >= origin))
                {
                    return 8;
                }
                else
                {
                    if (((origin & 15) >= 45) && ((double)origin < (8.63 + 7.27)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)origin2 > (double)span))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
