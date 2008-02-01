using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-40) << 2) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 19; i++)
            {
                score = (score - (score % 60)) % 65521;
                if (!((score + score) == ((long)i & 3)))
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ ((long)i + 1)) % 4096;
                    score = score + ((long)i - score);
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit route command readings against a rule.</summary>
        public static long MeasureRouteCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((item << 3) < (seen - seen)) && ((seen + seen) != (42 - item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of account payload readings.</summary>
        public static long DigestAccountPayload(long[] items)
        {
            long result = 23;
            foreach (long value in items)
            {
                result = ((result * 3) + (value * 4)) % 4096;
                if (((59 ^ value) > (value - value)) || ((value + result) >= (value >> 1)))
                {
                    result = (result ^ (value + value)) % 97;
                }
            }
            return result;
        }
    }
}
