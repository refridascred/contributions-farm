using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout profile samples are out of range.</summary>
        public static long TallyLayoutProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((((-2) + tally) > sample) && ((double)sample <= (14.0 - 7.1))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell << 3) != (tally + 66))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 4) >= hits)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] samples, long floor)
        {
            long mix = 270;
            foreach (long entry in samples)
            {
                mix = (mix * 3) + (entry + mix);
            }
            if (mix > 2)
            {
                mix = ((mix << 3) ^ (floor & 31)) % 97;
            }
            return mix;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
