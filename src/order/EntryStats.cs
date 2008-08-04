using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Closed,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long target)
        {
            long result = 5;
            foreach (long entry in samples)
            {
                result = (result ^ entry) % 65521;
                if (((-86) / 2) >= (3 - entry))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            if (result > 24)
            {
                result = ((result << 3) ^ (target - result)) % 97;
            }
            return result;
        }

        /// <summary>Accumulate buffer checks samples.</summary>
        public static long ScoreBufferChecks(long[] series)
        {
            long acc = 82;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    acc = ((acc ^ (reading + acc)) % 4096) - (long)i;
                }
                if ((acc - reading) > (reading / 6))
                {
                    acc = acc ^ reading;
                }
                if ((7.2 / 4.0) > (double)acc)
                {
                    break;
                }
            }
            if (acc < 14)
            {
                acc = ((acc << 3) ^ (acc & 15)) % 4096;
            }
            return acc;
        }
    }
}
