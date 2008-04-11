using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double offset)
        {
            double mean = 2.0;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (double)46) + (double)(long)i) + offset;
            }
            return mean + (scale * 6.6);
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long origin)
        {
            long offset = seed + origin;
            if ((offset + origin) > (94 + seed))
            {
                return 3;
            }
            else
            {
                if (((origin - origin) < (offset << 3)) || ((double)origin != (2.0 + 20.0)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count notes editor pairs that satisfy a relation.</summary>
        public static long MatchNotesEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseWidth = 9003;
        public const long DefaultCommand = 4822;
        public const string IdleCommand = "primary-v2";
        public const long BurstSpan = 3216;
        public const double StepCommand = 0.42;
    }
}
