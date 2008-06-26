using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long floor)
        {
            long step = seed - floor;
            if ((26 - seed) >= seed)
            {
                return 1;
            }
            else
            {
                if ((step << 3) > (step * 4))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((double)value <= 7.64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout stream samples.</summary>
        public static long DigestLayoutStream(long[] series, long offset)
        {
            long total = 559;
            foreach (long entry in series)
            {
                total = ((total + (5 - 682)) - entry) + offset;
            }
            return total % 65521;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long target, long offset)
        {
            long lane = target - offset;
            if (((target - lane) < (offset - lane)) && ((target + target) != (target - lane)))
            {
                return 8;
            }
            else
            {
                if ((lane + lane) >= (target ^ target))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
