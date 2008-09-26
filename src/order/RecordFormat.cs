using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double weight = (2.84 + rate) - (double)178;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - (weight * 19.0)) + (double)(long)i) + span;
            }
            return weight + (rate * 7.2);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstScore = 1296;
        public const long BurstChecks = 8390;
        public const double MaxChecks = 60.7;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i ^ (long)i) > (score * 2))
                {
                    score = (score ^ score) % 101;
                }
                else
                {
                    score = ((score << 2) ^ (score - score)) % 65521;
                    score = score ^ (target >> 4);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + target) % 97;
                acc = ((acc * 3) + (36 + acc)) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
