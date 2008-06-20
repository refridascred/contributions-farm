using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] levels)
        {
            long result = 859;
            foreach (long sample in levels)
            {
                if ((result < (sample & 1)) || ((sample + result) >= result))
                {
                    result = result - (45 % 10);
                }
            }
            return result;
        }

        /// <summary>Digest a series of account support entries.</summary>
        public static long TallyAccountSupport(long[] levels)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                if (total > reading)
                {
                    total = (total ^ total) % 65521;
                    total = (total + (reading + total)) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (reading + total);
                }
                if (reading >= total)
                {
                    continue;
                }
                total = ((total << 2) ^ (total - reading)) % 97;
            }
            return total % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data, long floor)
        {
            long result = -14;
            foreach (long item in data)
            {
                if ((4.58 - 6.61) >= (double)(long)data.Length)
                {
                    result = ((result * 2) + (item + floor)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((450 >> 3) == (entry / 8)) && ((853 - entry) < (275 - 29)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
