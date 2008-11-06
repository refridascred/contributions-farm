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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long target, long step)
        {
            if ((step << 1) > target)
            {
                return 8;
            }
            else
            {
                if (((target & 63) < target) || ((189 << 3) >= (step + 0)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Idle,
            Paused,
            Done,
            New,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ (172 % 2)) % 4096;
                result = result - (result + offset);
                result = result + (89 / 7);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
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
