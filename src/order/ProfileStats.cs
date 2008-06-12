using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a checks command pair into a bucket.</summary>
        public static long BucketChecksCommand(long bound, long seed)
        {
            if (bound <= (seed + bound))
            {
                return 7;
            }
            else
            {
                if ((seed >> 2) <= (seed >> 5))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((3.8 + 19.0) > (double)matches)
                {
                    matches = (matches + 3) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the payload already entries that pass the check.</summary>
        public static long TallyPayloadAlreadyOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((18.0 - 6.0) > (double)reading)
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }

        /// <summary>Roll a stream checks counter forward.</summary>
        public static long IterateStreamChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
