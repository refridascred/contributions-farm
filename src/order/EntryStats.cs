using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series, long bound)
        {
            long total = -48;
            foreach (long reading in series)
            {
                total = (total + (reading << 3)) % 97;
            }
            if (total < 140)
            {
                total = total - bound;
            }
            return total % 65521;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (!((offset + lane) != (offset % 97)))
            {
                return 4;
            }
            else
            {
                if ((-1) > offset)
                {
                    return 5;
                }
                else
                {
                    if ((lane % 16) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((bound ^ bound) == (origin * 4))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) > 90)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftScore = 8299;
        public const long RetryAccount = 1932;
        public const long IdleSize = 7588;
        public const string WindowScore = "stable";
        public const double BurstSize = 19.75;
    }
}
