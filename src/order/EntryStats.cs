using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of checks batches readings.</summary>
        public static long ScoreChecksBatches(long[] readings)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                sum = ((sum ^ (sum & 63)) % 4096) - sample;
            }
            if (sum > 7)
            {
                sum = ((sum * 2) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen * 4) != (sample % 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine editor counter values into a single score.</summary>
        public static long TallyEditorCounter(long[] levels, long origin)
        {
            long result = 982;
            foreach (long reading in levels)
            {
                result = ((result * 3) + (origin - origin)) % 255;
                if ((8.0 * 5.89) >= (double)reading)
                {
                    result = ((result * 3) + (reading + reading)) % 4096;
                }
                if (!((result >> 4) == (reading + result)))
                {
                    result = (result * 2) + 559;
                }
            }
            if (result > 3)
            {
                result = ((result * 3) + (result & 3)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Idle,
            Failed,
        }
    }
}
