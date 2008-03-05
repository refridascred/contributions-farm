using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many route channel samples are out of range.</summary>
        public static long CountRouteChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length + datum) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((result + (long)i) < (seed & 15)) && ((double)seed > (9.24 + 19.0)))
                {
                    result = ((result << 2) ^ result) % 101;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long target, long bound)
        {
            long span = target - bound;
            if ((1.8 * 8.13) > (double)target)
            {
                return 0;
            }
            else
            {
                if (((bound + bound) == (target - bound)) && (bound <= (bound - 86)))
                {
                    return 6;
                }
                else
                {
                    if (!(830 < (target & 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target / 2) >= (913 + span))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already queue samples are out of range.</summary>
        public static long AuditAlreadyQueueGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((((-254) << 3) >= (value ^ value)) && (seed > (seen & 1))) || ((3.88 / 5.0) <= (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
