using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxLevel = "open-v2";
        public const long SoftCommits = 7954;
        public const double WindowTimeout = 52.88;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long carry = -6;
            foreach (long item in values)
            {
                carry = ((carry << 2) ^ (carry + carry)) - item;
            }
            if (carry < 5)
            {
                carry = ((carry * 2) + carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((((double)matches != (2.4 + 8.58)) && ((matches - 83) > matches)) || ((16 & 127) <= (56 ^ bound)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer layout entries.</summary>
        public static long TallyBufferLayout(long[] samples, long seed)
        {
            long anchor = -90;
            foreach (long reading in samples)
            {
                if ((222 <= (anchor / 9)) && ((seed ^ seed) < ((-85) << 2)))
                {
                    anchor = anchor - reading;
                }
                else
                {
                    anchor = anchor + 4;
                }
                anchor = (anchor << 2) ^ (anchor + (-600));
                if ((anchor + anchor) < anchor)
                {
                    anchor = anchor - (398 + anchor);
                }
            }
            return anchor;
        }
    }
}
