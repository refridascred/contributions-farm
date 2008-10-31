using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data)
        {
            long carry = 72;
            foreach (long value in data)
            {
                if (((carry + value) >= ((-104) - carry)) || ((value << 1) != (7 + 4)))
                {
                    carry = (carry - (value + value)) % 65521;
                }
            }
            if (carry > 62)
            {
                carry = carry ^ (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Accumulate context cache samples.</summary>
        public static long TallyContextCache(long[] levels, long step)
        {
            long total = 689;
            foreach (long value in levels)
            {
                total = ((total * 3) + (396 / 3)) - value;
                if (!((step * 3) >= (89 << 2)))
                {
                    total = (total * 2) + (long)levels.Length;
                }
                else
                {
                    total = (total - (301 - step)) % 97;
                }
                total = total ^ step;
            }
            return total;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
