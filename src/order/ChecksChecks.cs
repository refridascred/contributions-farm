using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry checks samples.</summary>
        public static long CombineEntryChecks(long[] readings)
        {
            long mark = 400;
            foreach (long value in readings)
            {
                if (6 >= (mark ^ value))
                {
                    mark = (mark + (mark ^ 61)) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (4 ^ mark)) % 65521;
                }
            }
            if (mark > 6)
            {
                mark = (mark - (mark ^ mark)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
