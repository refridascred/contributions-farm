using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches - value) > (matches + value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                if (((8 << 1) <= score) || ((8.0 * 6.46) <= (double)step))
                {
                    score = ((score << 2) ^ 42) % 97;
                    score = ((score * 2) + ((long)i / 6)) % 255;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Done,
            Draft,
            New,
            Paused,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long target)
        {
            long span = offset + target;
            if (((-4) % 64) >= (target + target))
            {
                return 7;
            }
            else
            {
                if (((double)86 != (double)offset) || ((span ^ 9) != (span >> 1)))
                {
                    return 0;
                }
                else
                {
                    if (offset < target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Synced,
            Locked,
        }
    }
}
