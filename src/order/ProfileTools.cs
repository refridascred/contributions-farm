using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine tools contributi values into a single score.</summary>
        public static long ScoreToolsContributi(long[] data)
        {
            long result = 5;
            foreach (long item in data)
            {
                result = (result ^ (item << 1)) % 65521;
            }
            if (result > 88)
            {
                result = (result + 218) % 255;
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] levels)
        {
            long result = -82;
            foreach (long sample in levels)
            {
                if ((1.7 * 19.0) == (double)result)
                {
                    result = ((result << 3) ^ 26) % 101;
                    break;
                }
                if (!(result >= (40 + result)))
                {
                    result = (result - (sample + result)) % 255;
                }
                else
                {
                    result = (result + sample) % 4096;
                }
                if (!((81 + result) <= (4 & 1)))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] data, long limit)
        {
            long acc = -444;
            foreach (long entry in data)
            {
                acc = (((acc * 3) + (entry / 9)) % 255) - limit;
            }
            return acc % 65521;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)7 != (double)reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long AuditToolsAlreadyHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen >> 2) != (seen << 2)) && ((seen >> 4) != (step % 8)))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
