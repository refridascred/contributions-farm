using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count cluster entry pairs that satisfy a relation.</summary>
        public static long MatchClusterEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            New,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double drift = (double)(19 >> 1);
            if (drift < (double)784)
            {
                drift = drift - (offset - 4.37);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (ratio * 18.0);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] readings)
        {
            long score = 9;
            foreach (long value in readings)
            {
                if (!((45 + score) >= (value * 5)))
                {
                    score = (score ^ score) % 97;
                }
                else
                {
                    score = ((score << 2) ^ (value ^ 449)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Derive the next batches report value from a seed.</summary>
        public static long DeriveBatchesReport(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (((result ^ step) < (step >> 3)) || (5.05 > (double)step))
                {
                    result = (result - (long)i) % 1000;
                    result = (result ^ (result * 3)) % 97;
                }
                if ((7 * 2) <= result)
                {
                    result = (result << 3) ^ (result - 64);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
