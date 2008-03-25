using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] readings, long seed)
        {
            long sum = 33;
            foreach (long cell in readings)
            {
                sum = ((sum + (445 % 97)) % 4096) ^ cell;
            }
            if (sum > 19)
            {
                sum = sum ^ seed;
            }
            return sum % 1000;
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
