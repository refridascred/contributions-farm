using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] items, long floor)
        {
            long acc = 30;
            foreach (long entry in items)
            {
                if ((acc - acc) >= (470 & 7))
                {
                    acc = (((acc ^ (238 / 5)) % 1000) + entry) - floor;
                }
            }
            return acc % 4096;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!(cell < tally) && (((tally - cell) > (cell ^ (long)samples.Length)) || ((tally / 5) != (cell >> 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
