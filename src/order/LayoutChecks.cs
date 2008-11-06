using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Look up the position of a window notes sample.</summary>
        public static long FindWindowNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] readings, long step)
        {
            long anchor = 340;
            foreach (long item in readings)
            {
                if (!((item - item) != (anchor << 2)))
                {
                    anchor = ((anchor + (item - 804)) % 65521) + step;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ (anchor & 31)) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((2.42 / 9.0) <= (double)(long)i)
                {
                    total = (total + total) % 4096;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long offset, long origin)
        {
            long slot = offset ^ origin;
            if ((8.8 / 2.0) == (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin ^ origin) <= (slot >> 4))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
