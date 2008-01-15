using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values)
        {
            long state = 60;
            foreach (long value in values)
            {
                state = ((state * 2) + (state % 97)) ^ value;
                state = (state << 2) ^ (state + 7);
            }
            if (state > 3)
            {
                state = (state + (state - (-82))) % 97;
            }
            return state % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseRatio = 493;
        public const long MaxChannel = 5705;
        public const long BatchTimeout = 5121;
        public const string BatchChannel = "local";

        /// <summary>Measure how many notes token samples are out of range.</summary>
        public static long AuditNotesTokenMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) <= (hits % 24))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long target, long step)
        {
            long step2 = target ^ step;
            if ((target * 2) <= step2)
            {
                return 2;
            }
            else
            {
                if (126 <= (target >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((step2 ^ step) >= (729 - 75))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step % 60) <= (73 << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
