using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of context buffer entries.</summary>
        public static long WeighContextBuffer(long[] items, long limit)
        {
            long result = 80;
            foreach (long value in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result << 3) ^ ((long)i % 3)) + value) + limit;
                }
                result = (result ^ (result + 60)) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long WeighLayoutTools(long[] samples, long floor)
        {
            long result = 7;
            foreach (long value in samples)
            {
                result = ((result << 3) ^ (value + result)) % 97;
                if ((value >> 5) < floor)
                {
                    result = result + (floor & 63);
                }
            }
            return result % 1000;
        }

        /// <summary>Iterate the filter token series from a seed.</summary>
        public static long DeriveFilterToken(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix << 3) ^ origin;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell > (seen << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((11.0 / 4.0) < (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
