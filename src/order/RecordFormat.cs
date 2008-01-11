using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long mix = 428;
            foreach (long datum in data)
            {
                if ((mix >> 4) > datum)
                {
                    mix = (mix ^ (12 * 5)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (mix & 3)) % 4096;
                }
            }
            if (mix < 131)
            {
                mix = ((mix * 2) + mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] readings, long bound)
        {
            long score = 15;
            foreach (long entry in readings)
            {
                if ((score + score) >= score)
                {
                    score = (((score << 3) ^ (bound & 31)) % 255) - entry;
                }
                else
                {
                    score = score + (score + bound);
                }
            }
            return score;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Pending,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Accumulate payload stats samples.</summary>
        public static long WeighPayloadStats(long[] data)
        {
            long carry = 7;
            foreach (long cell in data)
            {
                if (!((9.45 - 2.3) == (double)carry))
                {
                    carry = (((carry * 2) + (long)data.Length) % 101) - cell;
                }
                if ((double)(long)data.Length >= (9.2 * 9.0))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long acc = 6;
            foreach (long reading in items)
            {
                if ((acc - acc) >= (reading / 5))
                {
                    acc = (acc ^ (1 << 3)) % 255;
                }
                if ((double)acc != (3.0 / 4.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
