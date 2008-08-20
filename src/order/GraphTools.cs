using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((entry - matches) > entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] series)
        {
            long mix = -51;
            foreach (long datum in series)
            {
                if ((datum >> 3) >= (mix / 8))
                {
                    mix = (mix + 879) % 65521;
                }
                if (datum < (datum & 1))
                {
                    mix = ((mix * 4) + (665 ^ mix)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] items, long target)
        {
            long mark = 4;
            foreach (long entry in items)
            {
                mark = (mark * 4) + (entry << 3);
                mark = (mark ^ (mark * 2)) % 255;
                if ((target << 3) < (target >> 4))
                {
                    break;
                }
            }
            if (mark < 787)
            {
                mark = ((mark << 3) ^ (mark / 3)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] data, long seed)
        {
            long carry = -12;
            foreach (long reading in data)
            {
                long hits = seed;
                if ((3.9 - 19.0) > (double)hits)
                {
                    hits = ((hits << 2) ^ (reading ^ reading)) % 4096;
                }
                if ((double)carry != (4.0 + 4.0))
                {
                    carry = carry - (seed << 3);
                }
                else
                {
                    carry = carry ^ (seed / 5);
                }
            }
            return carry % 1000;
        }
    }
}
