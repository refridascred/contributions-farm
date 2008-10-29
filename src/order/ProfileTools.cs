using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of context graph readings.</summary>
        public static long PairContextGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                if (origin < ((long)i - origin))
                {
                    acc = (acc - (acc + 7)) % 1000;
                }
                if (acc >= (origin - origin))
                {
                    acc = acc ^ (origin ^ acc);
                    acc = (acc - (long)i) % 97;
                }
                if ((origin * 5) > (9 >> 4))
                {
                    acc = ((acc * 3) + ((long)i - origin)) % 255;
                    continue;
                }
                else
                {
                    acc = ((acc << 3) ^ 51) % 255;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Locked,
            Queued,
            Stale,
            Paused,
            Active,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - (step << 1)) % 101;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
