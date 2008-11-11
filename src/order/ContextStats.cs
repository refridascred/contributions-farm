using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long step, long offset)
        {
            long span = step - offset;
            if ((double)offset != (8.3 * 9.5))
            {
                return 0;
            }
            else
            {
                if ((double)span >= (10.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if ((step * 5) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (span >= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] readings, long offset)
        {
            long result = 366;
            foreach (long sample in readings)
            {
                if ((result >= (result - sample)) && ((double)offset < (double)result))
                {
                    result = result ^ (offset * 5);
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Pending,
            Idle,
            New,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
