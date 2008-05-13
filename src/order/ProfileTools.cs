using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count window queue pairs that satisfy a relation.</summary>
        public static long MatchWindowQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (5 < (value + (-800)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Roll a format support counter forward.</summary>
        public static long IterateFormatSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc * 5) + (acc * 4);
                acc = ((acc << 2) ^ acc) % 97;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] series)
        {
            long anchor = 9;
            foreach (long entry in series)
            {
                if ((anchor - (long)series.Length) == ((long)series.Length + entry))
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of route support readings.</summary>
        public static long CombineRouteSupport(long[] samples)
        {
            long sum = 20;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= sample)
                {
                    sum = ((sum << 3) ^ (sample ^ sum)) % 255;
                }
            }
            return sum;
        }
    }
}
