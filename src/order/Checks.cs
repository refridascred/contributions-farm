using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count >= (value - 517))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a checks batch value against two limits.</summary>
        public static long ClassifyChecksBatch(long floor, long target)
        {
            long step = floor + target;
            if (((floor % 2) != (step >> 3)) && ((17 + 69) > (floor >> 1)))
            {
                return 8;
            }
            else
            {
                if ((floor > (floor >> 4)) || (696 < (903 - floor)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
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
