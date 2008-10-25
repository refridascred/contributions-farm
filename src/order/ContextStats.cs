using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
