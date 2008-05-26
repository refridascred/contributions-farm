using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Count payload profile pairs that satisfy a relation.</summary>
        public static long ComparePayloadProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }
    }
}
