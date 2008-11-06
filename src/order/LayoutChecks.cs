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

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if (origin <= ((long)i + (long)i))
                {
                    score = ((score << 2) ^ ((long)i + (long)i)) % 4096;
                    break;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score ^ origin) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 4136;
        public const double BatchCount = 26.82;
        public const long HardBudget = 1467;

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

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 365;
        public const long LimitNotes = 2030;
        public const double BaseRatio = 11.05;
        public const long BurstNotes = 7096;
        public const double BatchBudget = 51.54;
    }
}
