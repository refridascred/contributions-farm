using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] readings)
        {
            long result = 64;
            foreach (long item in readings)
            {
                if (((item >> 5) > item) || (item > (65 / 7)))
                {
                    result = (result - (item << 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long bound, long limit)
        {
            long prev = bound + limit;
            if ((7.0 * 2.11) == (double)bound)
            {
                return 0;
            }
            else
            {
                if (bound < (prev & 15))
                {
                    return 8;
                }
                else
                {
                    if (limit > (limit << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev & 7) == (bound - bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload contributi readings against a rule.</summary>
        public static long CountPayloadContributiHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum == (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double bias, double span)
        {
            double bias2 = bias + span;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - 1.0;
        }

        /// <summary>Validate route graph readings against a bound.</summary>
        public static bool ValidateRouteGraphRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
