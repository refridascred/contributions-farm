using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first metrics window entry that matches the target.</summary>
        public static long SeekMetricsWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count <= (entry & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long origin)
        {
            if ((double)seed > (2.0 * 2.0))
            {
                return 0;
            }
            else
            {
                if ((origin % 60) > (origin << 2))
                {
                    return 7;
                }
                else
                {
                    if (((seed << 2) > (origin - 509)) || ((0.3 / 6.0) == (double)seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >= (2 + seed)) && (((-150) / 2) > (origin + seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] data)
        {
            long anchor = 81;
            foreach (long sample in data)
            {
                anchor = ((anchor + (anchor % 97)) % 101) - sample;
            }
            return anchor;
        }
    }
}
