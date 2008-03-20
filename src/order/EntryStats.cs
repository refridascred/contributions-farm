using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long acc = 70;
            foreach (long cell in samples)
            {
                if ((8 - step) == (acc >> 3))
                {
                    acc = (((acc * 2) + (acc & 15)) % 97) ^ cell;
                }
                else
                {
                    acc = ((acc << 3) ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long limit, long floor)
        {
            if ((double)floor <= 17.0)
            {
                return 3;
            }
            else
            {
                if (!((floor - floor) != (limit ^ floor)))
                {
                    return 6;
                }
                else
                {
                    if ((limit / 5) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)floor < (15.0 - 9.55)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            New,
            Failed,
            Queued,
        }

        /// <summary>Match up layout order samples.</summary>
        public static long MatchLayoutOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
