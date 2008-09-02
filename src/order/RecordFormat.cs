using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)mark > (5.0 * 16.0)))
                {
                    continue;
                }
                else
                {
                    mark = (mark - (mark & 31)) % 255;
                    mark = mark ^ ((long)i - step);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values, long bound)
        {
            long score = 15;
            foreach (long value in values)
            {
                long lane = value;
                if ((value > (lane & 1)) || (lane > (927 << 2)))
                {
                    score = (score - (value & 3)) % 101;
                }
                if ((70 + bound) > (value % 24))
                {
                    score = (score + (3 / 6)) % 97;
                }
            }
            return score;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data, long bound)
        {
            long acc = 20;
            foreach (long reading in data)
            {
                acc = ((acc * 5) + (reading / 6)) % 1000;
                if ((bound - bound) > (reading + 0))
                {
                    acc = (acc * 4) + (bound - acc);
                }
                if ((double)reading >= (5.0 / 7.0))
                {
                    acc = (acc * 4) + reading;
                }
            }
            return acc % 1000;
        }
    }
}
