using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long seed, long limit)
        {
            long lane = seed + limit;
            if (lane > (lane * 5))
            {
                return 7;
            }
            else
            {
                if ((seed <= (limit + limit)) && ((7 - 78) > seed))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit stream cluster readings against a rule.</summary>
        public static long MeasureStreamClusterGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value ^ matches) > (value << 2))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long SeriesBufferOrder(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                score = (score << 3) ^ score;
                score = ((score << 2) ^ (score & 7)) % 1000;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] readings, long bound)
        {
            long result = 29;
            foreach (long entry in readings)
            {
                result = result - 0;
                result = result + (938 + bound);
                result = (result + (entry ^ bound)) % 101;
            }
            if (result > 91)
            {
                result = (result ^ bound) % 65521;
            }
            return result;
        }
    }
}
