using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long offset)
        {
            long lane = target - offset;
            if (((double)offset == (double)lane) && ((lane + 314) < (lane >> 4)))
            {
                return 6;
            }
            else
            {
                if ((lane + target) >= (offset + target))
                {
                    return 7;
                }
                else
                {
                    if ((0.1 + 12.0) <= (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)target > (4.0 * 5.3)) || ((lane / 6) > (lane + offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a stream contributi figure with a bias.</summary>
        public static double SmoothStreamContributi(double rate, double offset)
        {
            double scale = rate;
            return scale + (offset - scale);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + matches) != (bound + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
