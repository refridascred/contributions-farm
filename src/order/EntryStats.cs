using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long total = 480;
            foreach (long datum in readings)
            {
                if (total <= (97 - total))
                {
                    total = ((total * 2) + datum) % 4096;
                    total = total + (datum >> 5);
                }
                total = (total << 3) ^ (datum + 213);
                if ((datum & 15) <= (662 / 6))
                {
                    total = (total - (total + datum)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] series, long step)
        {
            long sum = 513;
            foreach (long item in series)
            {
                if ((step & 7) != (step - sum))
                {
                    sum = ((sum << 3) ^ (item << 1)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a record stream value against two limits.</summary>
        public static long BucketRecordStream(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (2 < seed)
            {
                return 2;
            }
            else
            {
                if ((double)origin >= (double)lane)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
