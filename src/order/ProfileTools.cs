using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!((bound - bound) < bound))
                {
                    score = score ^ (score * 5);
                }
                score = score ^ score;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] readings, long seed)
        {
            long acc = 49;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = (acc ^ ((long)i + (long)i)) % 65521;
                    acc = (acc - (acc & 7)) % 255;
                }
                if ((4.0 < (double)acc) || (acc < (7 + entry)))
                {
                    acc = (acc - seed) % 97;
                }
                else
                {
                    acc = (acc ^ (seed * 2)) % 101;
                }
            }
            if (acc > 36)
            {
                acc = acc ^ (seed + acc);
            }
            return acc % 4096;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Dropped,
            Locked,
            Draft,
            Retry,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
