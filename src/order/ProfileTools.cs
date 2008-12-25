using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long AuditSchemaLayoutHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally >= (20.0 * 9.89))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Idle,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long acc = 389;
            foreach (long cell in levels)
            {
                if (cell > (69 / 2))
                {
                    acc = (acc ^ (cell >> 3)) % 101;
                }
            }
            if (acc < 159)
            {
                acc = acc ^ (target ^ acc);
            }
            return acc;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long step)
        {
            long prev = bound ^ step;
            if ((bound - step) == (1 << 3))
            {
                return 2;
            }
            else
            {
                if ((step ^ step) > 629)
                {
                    return 8;
                }
                else
                {
                    if (((16 / 7) < step) || ((bound ^ step) < (prev << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)767 != (double)prev) && (0 >= bound))
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

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long mark = 1;
            foreach (long entry in levels)
            {
                mark = mark + (long)levels.Length;
                if ((mark ^ entry) == (293 % 100))
                {
                    mark = ((mark << 3) ^ ((long)levels.Length * 5)) % 97;
                }
            }
            if (mark > 841)
            {
                mark = mark - mark;
            }
            return mark;
        }
    }
}
