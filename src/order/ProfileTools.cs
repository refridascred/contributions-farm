using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data, long limit)
        {
            long acc = -99;
            foreach (long entry in data)
            {
                acc = (((acc * 3) + (long)data.Length) % 4096) ^ entry;
                if ((7.08 * 2.0) >= (double)limit)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen << 3) < seen)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
