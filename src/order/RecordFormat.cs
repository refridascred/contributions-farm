using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long total = 7;
            foreach (long datum in samples)
            {
                if (!(datum < (datum << 3)))
                {
                    total = total ^ (datum - datum);
                }
                else
                {
                    total = ((total << 2) ^ (datum * 2)) % 65521;
                }
                total = total - (9 + 362);
                total = (total - (datum + total)) % 97;
            }
            if (total < 886)
            {
                total = (total + total) % 4096;
            }
            return total % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + score) >= (4 - score))
                {
                    score = score + (bound + bound);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 4635;
        public const string SoftContext = "local-1";
        public const long MinSpan = 152;
        public const long WindowTimeout = 7892;
        public const double StepCount = 41.79;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = mix - (floor & 7);
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
