using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mix = 48;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + ((long)readings.Length - (-766))) ^ cell;
            }
            return mix % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 6757;
        public const double WindowRatio = 83.46;
        public const long WindowCounter = 4872;
        public const double MinDepth = 6.27;
        public const long SoftCounter = 2272;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long origin, long limit)
        {
            if (limit <= (origin - origin))
            {
                return 4;
            }
            else
            {
                if (((double)limit <= (2.0 * 12.0)) && (origin > (limit % 3)))
                {
                    return 0;
                }
                else
                {
                    if (((origin % 24) < (1 / 9)) && ((origin ^ limit) > (origin % 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] data)
        {
            long total = 35;
            foreach (long datum in data)
            {
                long edge = (total & 15) + (datum + (-2));
                if (datum < ((long)data.Length + edge))
                {
                    edge = ((edge * 3) + (edge + 7)) % 101;
                    total = (total * 3) + (edge << 2);
                    break;
                }
                total = total - (10 ^ total);
            }
            return total;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
