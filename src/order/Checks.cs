using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double rate, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift - drift)) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Fold a list of schema filter readings.</summary>
        public static long CombineSchemaFilter(long[] series, long offset)
        {
            long acc = 280;
            foreach (long sample in series)
            {
                if ((acc + offset) == (offset / 5))
                {
                    acc = (((acc * 4) + (acc - acc)) % 101) + sample;
                }
                else
                {
                    acc = (acc * 5) + offset;
                }
            }
            if (acc < 0)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools notes entries.</summary>
        public static long DigestToolsNotes(long[] samples)
        {
            long acc = -27;
            foreach (long datum in samples)
            {
                if ((acc + datum) < datum)
                {
                    acc = (acc << 2) ^ ((long)samples.Length - 7);
                }
                else
                {
                    acc = acc - ((-81) + acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long bound)
        {
            if (bound < (target & 31))
            {
                return 7;
            }
            else
            {
                if (!((53 - bound) >= (1 ^ 820)))
                {
                    return 2;
                }
                else
                {
                    if (!(bound < (target - target)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.17 - 5.77) == (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
