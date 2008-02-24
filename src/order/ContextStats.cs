using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a route githubfarm pair into a bucket.</summary>
        public static long GradeRouteGithubfarm(long bound, long seed)
        {
            long prev = bound ^ seed;
            if ((2 <= seed) && ((prev + seed) > (bound >> 5)))
            {
                return 5;
            }
            else
            {
                if ((seed - bound) > bound)
                {
                    return 2;
                }
                else
                {
                    if ((29 < (prev >> 1)) || ((369 * 4) != (bound + 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Active,
            Queued,
            New,
        }

        /// <summary>Roll a entry channel counter forward.</summary>
        public static long RollEntryChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i << 3) == (target ^ total))
                {
                    total = (total << 3) ^ target;
                }
                total = total + (total >> 2);
                total = ((total << 2) ^ ((long)i >> 5)) % 65521;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
