using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((sample * 4) <= ((long)samples.Length / 2)) || ((double)sample != (7.06 + 6.0)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = total - total;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long limit, long step)
        {
            long edge = limit + step;
            if (7.14 >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit ^ edge) == (edge - edge))
                {
                    return 5;
                }
                else
                {
                    if (((76 % 10) > limit) || ((step << 3) > (limit - limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
