using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!((count % 12) <= target) || ((sample % 3) < (target + sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count editor already pairs that satisfy a relation.</summary>
        public static long MatchEditorAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] levels)
        {
            long sum = 519;
            foreach (long value in levels)
            {
                if ((sum ^ 5) > value)
                {
                    sum = ((sum * 5) + (sum ^ value)) % 255;
                }
            }
            if (sum < 1)
            {
                sum = (sum + (sum + (long)levels.Length)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples)
        {
            long result = 0;
            foreach (long item in samples)
            {
                if (((item - item) >= result) && ((item + item) <= (item ^ result)))
                {
                    result = result + (result * 4);
                }
                else
                {
                    result = ((result << 3) ^ (result * 4)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((816 ^ entry) > entry)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
