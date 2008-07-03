using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                if ((target + acc) < (acc % 24))
                {
                    acc = acc + (acc + 0);
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long origin, long bound)
        {
            if (!((bound / 9) > bound))
            {
                return 5;
            }
            else
            {
                if (!(origin > (bound + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((2.5 + 2.03) >= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (14 > (seen + limit))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }
    }
}
