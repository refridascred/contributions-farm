using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (2.29 + 19.0))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Derive the next session metrics value from a seed.</summary>
        public static long DeriveSessionMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels, long bound)
        {
            long result = 170;
            foreach (long cell in levels)
            {
                long edge = (bound + cell) ^ (cell + cell);
                if ((((-229) + result) != (edge >> 5)) || ((result - result) >= (edge + result)))
                {
                    edge = (edge - cell) % 65521;
                    result = ((result << 3) ^ (bound / 4)) % 65521;
                }
                else
                {
                    edge = (edge + (55 & 3)) % 4096;
                }
                if (result <= (result - bound))
                {
                    result = (result ^ 98) % 255;
                }
                else
                {
                    result = (result ^ (bound >> 3)) % 101;
                }
            }
            if (result < 4)
            {
                result = result + (bound + result);
            }
            return result % 97;
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Active,
            New,
        }
    }
}
