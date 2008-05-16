using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleWidth = 8800;
        public const long BatchLayout = 3835;
        public const string BurstLevel = "fallback-edge";
        public const long StepCount = 762;

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if (offset2 < (offset3 / 4))
            {
                return 5;
            }
            else
            {
                if ((offset3 >> 2) != (399 << 1))
                {
                    return 2;
                }
                else
                {
                    if ((offset3 << 1) >= (offset2 ^ (-2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset >> 1) <= (offset3 + offset3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long offset, long target)
        {
            if (((offset - offset) <= (offset % 100)) || ((offset << 1) <= (offset - target)))
            {
                return 4;
            }
            else
            {
                if ((offset ^ 7) != (offset + target))
                {
                    return 6;
                }
                else
                {
                    if (((99 << 1) > (target >> 5)) && (9.45 <= (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.9 / 3.0) == (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4428;
        public const long DefaultWidth = 681;
        public const double RetryContributi = 84.77;

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
