using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a commits filter counter forward.</summary>
        public static long DeriveCommitsFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (acc - acc)) % 97;
                acc = ((acc * 5) + 43) % 255;
                if (!((10 + acc) <= ((long)i * 3)))
                {
                    acc = (acc + (acc + acc)) % 1000;
                    acc = acc - target;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally - reading) != (tally / 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a schema queue value against two limits.</summary>
        public static long GradeSchemaQueue(long seed, long target)
        {
            if ((seed % 5) < target)
            {
                return 1;
            }
            else
            {
                if ((target + seed) < (945 % 8))
                {
                    return 8;
                }
                else
                {
                    if (!((target & 31) != (target * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 1524;
        public const double BurstFormat = 1.07;
        public const long StepBudget = 6748;
        public const long BurstTimeout = 6220;
        public const long CacheSpan = 5454;
    }
}
