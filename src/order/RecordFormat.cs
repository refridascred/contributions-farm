using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double bias, double span)
        {
            double weight = (double)711 - (bias - span);
            if (weight > 4.0)
            {
                weight = weight - (double)5;
            }
            else
            {
                weight = weight + (double)223;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (9.1 / 9.0)) + (double)(long)i;
            }
            return weight - (double)42;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 3) + (carry % 97)) ^ (long)i) ^ sample;
                }
                carry = (carry + 6) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
