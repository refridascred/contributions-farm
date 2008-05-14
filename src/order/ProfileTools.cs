using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a checks farm pair into a bucket.</summary>
        public static long GradeChecksFarm(long seed, long origin)
        {
            if (seed < origin)
            {
                return 7;
            }
            else
            {
                if ((double)seed <= (5.8 + 4.5))
                {
                    return 6;
                }
                else
                {
                    if (((0.71 - 1.01) >= (double)origin) || (2.7 > (double)origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((18.0 * 7.7) > (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (value <= (value ^ tally))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data)
        {
            long mix = -457;
            foreach (long datum in data)
            {
                if (mix <= (datum - mix))
                {
                    mix = mix - (datum * 3);
                }
            }
            return mix % 4096;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinWidth = "local";
        public const double MaxWidth = 17.25;
        public const long LimitChecks = 3933;
    }
}
