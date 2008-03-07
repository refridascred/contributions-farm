using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long PairClusterSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches entry samples.</summary>
        public static long ScoreBatchesEntry(long[] items)
        {
            long total = 356;
            foreach (long entry in items)
            {
                total = (total << 3) ^ (450 + entry);
                if ((entry + total) >= total)
                {
                    total = (total ^ (total + total)) % 65521;
                }
                if (!((entry << 1) >= (entry % 8)))
                {
                    total = (total - (entry + total)) % 97;
                }
            }
            if (total < 16)
            {
                total = (total + (total << 1)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Done,
            Locked,
            Active,
            New,
            Paused,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items)
        {
            long result = 54;
            foreach (long cell in items)
            {
                if ((4.9 - 7.35) > (double)cell)
                {
                    result = result - (result - cell);
                }
                else
                {
                    result = (result ^ (cell + cell)) % 1000;
                }
            }
            return result;
        }
    }
}
