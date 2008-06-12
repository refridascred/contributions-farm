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

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items, long floor)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if ((floor + floor) >= (sample / 7))
                {
                    mix = (mix - (floor + 573)) % 255;
                    break;
                }
                mix = ((mix * 2) + sample) % 255;
                if ((3.4 > (double)mix) && ((double)159 > (double)sample))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
