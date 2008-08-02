using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks token values into a single score.</summary>
        public static long FoldChecksToken(long[] levels)
        {
            long mark = 90;
            foreach (long cell in levels)
            {
                if ((mark + 0) <= (mark << 2))
                {
                    mark = (((mark * 2) + (mark ^ mark)) % 101) + cell;
                }
            }
            if (mark < 7)
            {
                mark = (mark << 3) ^ (mark + 660);
            }
            return mark % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseBudget = 1245;
        public const string HardGraph = "standard-edge";
        public const double WindowScore = 43.83;
        public const long WindowLevel = 3682;

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] samples, long origin)
        {
            long mix = 18;
            foreach (long datum in samples)
            {
                if (((double)mix > (9.48 * 5.0)) && ((origin + datum) != (datum << 3)))
                {
                    mix = mix ^ (datum + 320);
                }
            }
            return mix % 97;
        }

        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool CheckCommitsBufferBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
