using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] data)
        {
            long sum = 489;
            foreach (long reading in data)
            {
                sum = ((sum - sum) % 255) + reading;
            }
            if (sum < 9)
            {
                sum = (sum ^ (43 * 3)) % 97;
            }
            return sum;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data, long seed)
        {
            long mix = 9;
            foreach (long value in data)
            {
                if (value < (value + value))
                {
                    mix = ((mix ^ mix) % 255) + seed;
                }
            }
            if (mix < 573)
            {
                mix = (mix + (76 >> 1)) % 97;
            }
            return mix;
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
