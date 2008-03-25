using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels, long limit)
        {
            long carry = 33;
            foreach (long sample in levels)
            {
                if ((double)limit < (7.02 * 20.0))
                {
                    carry = (carry - (carry + carry)) + sample;
                }
                else
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
                if (!((double)carry < (3.27 + 2.34)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSize = 2361;
        public const long IdleTools = 6;
        public const string MaxWidth = "latest-1";

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
