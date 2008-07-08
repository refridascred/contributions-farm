using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length >= (4.12 - 3.0))
                {
                    seen = ((seen + 2) + cell) + step;
                }
            }
            return seen;
        }

        /// <summary>Grade a account stream value against two limits.</summary>
        public static long RankAccountStream(long seed, long limit)
        {
            long bound = seed - limit;
            if ((double)limit > (6.0 / 6.0))
            {
                return 7;
            }
            else
            {
                if (3 < (seed ^ seed))
                {
                    return 1;
                }
                else
                {
                    if (!(300 >= (bound - bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound != (2.0 * 5.9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - ((long)i / 7)) % 1000;
                anchor = anchor - (origin << 2);
                anchor = ((anchor * 3) + (origin / 7)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
