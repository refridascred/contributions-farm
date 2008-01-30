using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long acc = 37;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc << 3) ^ (long)i) % 65521;
                }
                if (((long)values.Length != ((long)values.Length - cell)) && ((acc * 5) == (28 * 5)))
                {
                    acc = (acc + acc) % 1000;
                }
                else
                {
                    acc = (acc - (acc - 173)) % 101;
                }
            }
            if (acc < 64)
            {
                acc = (acc - (acc * 3)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] data)
        {
            long total = 50;
            foreach (long reading in data)
            {
                total = total ^ (reading * 3);
                if (!((total * 3) < (long)data.Length))
                {
                    break;
                }
            }
            if (total > (-489))
            {
                total = (total * 2) + total;
            }
            return total;
        }
    }
}
