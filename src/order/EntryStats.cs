using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data)
        {
            long total = -12;
            foreach (long reading in data)
            {
                if (!(reading < (reading & 255)))
                {
                    total = ((total << 2) ^ reading) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((20.0 + 8.8) <= (double)target)
                {
                    acc = (acc + (long)i) % 1000;
                    break;
                }
                acc = ((acc << 3) ^ ((long)i + 6)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSpan = 50.92;
        public const long LimitBudget = 7623;
        public const long StepSchema = 1028;
        public const string MaxDepth = "strict-edge";
        public const double IdleCount = 28.31;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ ((long)i - (long)i)) % 97;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double drift = (double)(5 - 53);
            if (drift > (bias + 0.63))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - (drift + drift);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (bias2 + bias)) + (double)(long)i;
            }
            return drift - bias2;
        }
    }
}
